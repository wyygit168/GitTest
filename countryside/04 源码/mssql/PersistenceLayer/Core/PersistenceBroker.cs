using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PersistenceLayer
{
	/// <summary>
	/// ʵ���Ĺؼ��� 
	/// ��������Persistence Mechanisms������
	/// ���������ǵĳ�������ǵĽ���
	/// ʹ��Singletonģʽ 
	/// </summary>
	class PersistenceBroker
	{
		private static PersistenceBroker _instance;
		
		private IDictionary DatabasePool;							//���ݿ⼯��
		private IDictionary ClassMaps;		
		public bool MultiDatabase = false;

		//Constructor
		/// <summary>
		/// ���췽��.��ʹ��PL��ʱ,�ض�Ҫ����������췽ʽ.�����ݿ�ӳ�����ӳ�䶼�����ڴ�.
		/// </summary>
		protected PersistenceBroker()
		{

			Setting oSetting=Setting.Instance();
			//δָ��Xml�ļ� ·��
			if(oSetting.DatabaseMapFile=="*")
			{
				//throw new PlException("δ����Xml�ļ�·����");
				IConfigLoader config=XmlConfigLoader.Instance();
				this.DatabasePool=config.DatabasePool;
				this.ClassMaps=config.ClassMaps;
			}
			else
			{
				//�Ӷ�ȡXml�ļ��������ӳ����Ϣ
				IConfigLoader config=XmlConfigLoader.Instance();
				config.LoadConfig(oSetting.DatabaseMapFile);
				this.DatabasePool=config.DatabasePool;
				this.ClassMaps=config.ClassMaps;
				if (this.DatabasePool.Count > 1) this.MultiDatabase = true;

				//����Setting ��Ķ���
				foreach(RelationalDatabase rdb in this.DatabasePool.Values)
				{
					oSetting.SetConnectionString(rdb.Name,rdb.ConnectionString);
				}
			}
		}

		/// <summary>
		///		�õ�PersistenceBroker��ʵ��
		/// </summary>
		public static PersistenceBroker Instance()
		{
			if(_instance==null)
			{
				lock(typeof(PersistenceBroker))
				{
					if(_instance==null) 
					{
						_instance=new PersistenceBroker();
					}
				}
			}
			return _instance;
		}

		//����һCommand
		public IDbCommand GetCommand (string dbName)
		{
			RelationalDatabase rdb = this.GetDatabase(dbName);
			return rdb.GetCommand();
		}

		//����Command����һ��DataTable
		public DataTable ExecuteQuery(IDbCommand cmd,string rdbName)
		{
			RelationalDatabase rdb = null;
			if (rdbName == "")
			{
				rdb = this.GetDatabase().GetCopy ();
			}
			else
			{
				rdb=this.GetDatabase (rdbName).GetCopy();
			}
			try
			{
				rdb.Open();
				DataTable dt=rdb.AsDataTable(cmd);
				return dt;
			}
			catch(Exception e)
			{
				this.ErrorHandle(e,null);
			}
			finally
			{
				rdb.Close();
			}
			return null;
		}
		

		//����Command����һ��DataTable
		/// <summary>
		/// ����ǰN����¼
		/// add by tintown at 2004-09-06
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="rdbName"></param>
		/// <param name="top">N</param>
		/// <returns></returns>
		public DataTable ExecuteQuery(IDbCommand cmd,string rdbName,int top)
		{
			RelationalDatabase rdb = null;
			if (rdbName == "")
			{
				rdb = this.GetDatabase().GetCopy ();
			}
			else
			{
				rdb=this.GetDatabase (rdbName).GetCopy();
			}
			try
			{
				rdb.Open();
				DataTable dt=rdb.AsDataTable(cmd,top);
				return dt;
			}
			catch(Exception e)
			{
				this.ErrorHandle(e,null);
			}
			finally
			{
				rdb.Close();
			}
			return null;
		}



        /// <summary>
        /// ����Command����һ��DateSet
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="rdbName"></param>
        /// <returns></returns>
        public DataSet ExecuteMultiQuery(IDbCommand cmd, string rdbName)
        {
            RelationalDatabase rdb = null;
            if (rdbName == "")
            {
                rdb = this.GetDatabase().GetCopy();
            }
            else
            {
                rdb = this.GetDatabase(rdbName).GetCopy();
            }
            try
            {
                rdb.Open();
                DataSet ds = rdb.AsDataSet(cmd);
                return ds;
            }
            catch (Exception e)
            {
                this.ErrorHandle(e, null);
            }
            finally
            {
                rdb.Close();
            }
            return null;
        }

		//ȡһ��ʵ�����
		public bool RetrieveObject(EntityObject obj,bool isRetrieveAssociation)
		{
			ClassMap cm=this.GetClassMap(obj.GetClassName());
			RelationalDatabase rdb;
			//tintown add at 2004-10-23
			//Ҫ��ָ��������Դ�����ָ��������Դ��ȡ����
			if(obj.DatabaseName==null)
               rdb = cm.RelationalDatabase.GetCopy ();
			else
				rdb = this.GetDatabaseCopy(obj.DatabaseName);
			bool result=true;
			try
			{
				rdb.Open();
				result = this.RetrievePrivate(obj,cm,rdb,isRetrieveAssociation);
			}
			catch(Exception e)
			{
				this.ErrorHandle(e,obj);
			}
			finally
			{
				rdb.Close();
			}
			return result;
		}
		//�������У�ȡһ��ʵ����� 
		private bool RetrieveObject(EntityObject obj ,RelationalDatabase rdb)
		{
			ClassMap cm=this.GetClassMap(obj.GetClassName());
			bool result=true;
			result = this.RetrievePrivate(obj,cm,rdb,true);
			return result;		
		}

		private bool RetrievePrivate(EntityObject obj,ClassMap cm,RelationalDatabase rdb,bool isRetrieveAssociation)
		{
			IDbCommand cmd=cm.GetSelectSqlFor(obj);
			IDataReader reader = rdb.GetDataReader(cmd);
			if (reader.Read())
			{
				this.SetObject(obj,reader,cm);
				reader.Close();				
				obj.IsPersistent=true;

//				obj.DirtyCode=DirtyControl.Instance().GetDirtyCode(obj.DirtyKey);

				if(obj.IsSaveToMemory)
                    SaveToMemory(obj.MemoryKey,cm,rdb);
			}
			else
			{
				reader.Close();				
				obj.IsPersistent=false;
				return false;
			}

			/*����Associations*/
			if (!isRetrieveAssociation) return true;

			EntityObject aEntityObject;
			object aValue;
			string aName;
			string target;
			Association a;
			ClassMap clsMap;

			if (cm.HasAssociation())
			{
				for(int i=0;i<cm.Associations.Count;i++)
				{
					a=(Association)cm.Associations[i];
					if (!a.RetrieveAutomatic) break;
					aName=a.ToAttribute;
					target=a.Target;
					aValue=obj.GetAttributeValue(a.FromAttribute);
					if (a.Cardinality==CardinalityTypes.OneToOne)
					{
						//��ȡ�����������󲢳�ʼ��
						aEntityObject=(EntityObject)obj.GetAttributeValue(target);
						if (aEntityObject==null) break;
						aEntityObject.SetAttributeValue(aName,aValue);
						clsMap=this.GetClassMap(aEntityObject.GetClassName());
						this.RetrievePrivate(aEntityObject,clsMap,rdb,true);
					}
					else
					{
						//��ȡ�������:
						EntityObjectCollection col;
						col = (EntityObjectCollection)obj.GetAttributeValue(a.Target);
						if (col == null) break;
						clsMap = (ClassMap ) this.ClassMaps [a.ToClass];
						AttributeMap am = clsMap.GetAttributeMap (aName,true);
						SelectionCriteria selCriteria = new SelectionCriteria (SelectionTypes.EqualTo,am,aValue,clsMap);
						
						IDbCommand command = clsMap.GetSelectSqlFor (selCriteria);
						DataTable dt = rdb.AsDataTable (command);
						for (int j =0 ;j < dt.Rows.Count;j ++)
						{
							aEntityObject = (EntityObject)obj.GetType().Assembly.CreateInstance(col.FullName);
							clsMap.SetObject(aEntityObject,dt.Rows[j]);
							this.RetrievePrivate (aEntityObject,clsMap,rdb,true);
							col.Add (aEntityObject);
						}
					}
				}//End of for
			}//end of if
			return true;
		}


		public void SaveToMemory(string memoryKey,ClassMap cm,RelationalDatabase rdb)
		{
				IDbCommand cmd=rdb.GetCommand();
				cmd.CommandText=cm.SelectFromClause;
				DataTable dt=rdb.AsDataTable(cmd);
				GlobalCacheControl.Instance().Add(memoryKey,dt);
			
		}
		
		//����DataReader ����EntityObject����
		private void SetObject(EntityObject obj,IDataReader reader,ClassMap cm)
		{
			AttributeMap am;
			int count;
			int i,j = 0;
			object objTmp;
			do
			{
				//tintown add by 2004-10-23
				//��ʵ������ݿ������Ը���ֵ
				if(obj.DatabaseName==null)
                    obj.DatabaseName=cm.RelationalDatabase.Name;

				obj.IsSaveToMemory=cm.IsSaveToMemory;

				count = cm.SelfClassAttributes.Count;
				for(i = 0;i<count;i++)
				{
					am= (AttributeMap) cm.SelfClassAttributes[i];//GetAttributeMap(i);
					objTmp = reader[j++];
					if (objTmp!=DBNull.Value)
					{
						obj.SetAttributeValue(am.Name,objTmp);
					}
				}
				cm = cm.SuperClass;
			}while (cm != null);
		}
		
		//ɾ��һ��ʵ�����
		public int DeleteObject(EntityObject obj)
		{
			int result = 0;
			ClassMap cm=this.GetClassMap(obj.GetClassName());
			IDbCommand cmd=cm.GetDeleteSqlFor(obj);
			RelationalDatabase rdb;
			//tintown add at 2004-10-23
			//�ж����ʵ������ݿ�����Ϊnull����ʹ��ʵ������ݿ�����
			if(obj.DatabaseName==null)
			{
				rdb = cm.RelationalDatabase.GetCopy ();
			}
			else
			{
				rdb=this.GetDatabase(obj.DatabaseName).GetCopy();
			}
			try
			{
				rdb.Open();
				if(cm.HasAssociation()) rdb.BeginTransaction();
				result=this.DeletePrivate(obj,cm,rdb);
				if(cm.HasAssociation()) rdb.CommitTransaction();


			}
			catch(Exception e)
			{
				if (cm.HasAssociation()) rdb.RollbackTransaction();
				this.ErrorHandle (e,obj);
			}
			finally
			{
				rdb.Close();
			}
			return result;
		}


		//ɾ��һ��ʵ�����(��������)
		public int DeleteObject(EntityObject obj,RelationalDatabase rdb)
		{
			int result=0;
			ClassMap cm=this.GetClassMap(obj.GetClassName());			
			result=this.DeletePrivate(obj,cm,rdb);
			if(result==0)
                obj.IsPersistent=false;
			return result;
			
		}

		/// <summary>
		/// add by tintown at 2004-09-06
		/// ִ��SQL���
		/// </summary>
		/// <param name="sqlstring">���</param>
		/// <param name="rdb">���ݿ�</param>
		public int ExecuteSql(string sqlstring,RelationalDatabase rdb)
		{
			return rdb.DoSql(sqlstring);
		}

	

		private int DeletePrivate(EntityObject obj,ClassMap cm,RelationalDatabase rdb)
		{
			/*����Associations*/
			if(cm.HasAssociation())
			{
				int i;
				int c=cm.Associations.Count;
				Association a;
				EntityObject aObject;
				ClassMap clsMap;

				for(i=0;i<c;i++)
				{
					a=(Association)cm.Associations[i];
					if (!a.DeleteAutomatic) break;
					if(a.Cardinality==CardinalityTypes.OneToOne)
					{
						aObject=(EntityObject)obj.GetAttributeValue(a.Target);
						if (aObject==null)break;
						clsMap=this.GetClassMap(aObject.GetClassName());
						this.DeletePrivate(aObject,clsMap,rdb);
					}
					else
					{
						EntityObjectCollection col=(EntityObjectCollection)obj.GetAttributeValue(a.Target);
						if (col==null) break;
						int size = col.Objects.Count;
						for(int j=0;j< size;j++)
						{
							aObject=(EntityObject)col.Objects[j];
							clsMap=this.GetClassMap(aObject.GetClassName());							
							this.DeletePrivate(aObject,clsMap,rdb);
						}
						//col.Clear();
					}
				}

			}
			

			//Delete self including base objects
		//	do
			//{
			int result=0;
			result=rdb.DoCommand(cm.GetDeleteSqlFor(obj));
				//cm = cm.SuperClass;
			//}while (cm != null);

			if(obj.IsSaveToMemory && result>0)
                SaveToMemory(obj.MemoryKey,cm,rdb);
		

			return result;
		}
		
		//�������������Ӧ��ClassMap
		public ClassMap GetClassMap(string name)
		{
			ClassMap cm;
			cm=(ClassMap)ClassMaps[name];

			if(cm==null)
			{
				throw new PlException("δ�ҵ���Ϊ["+name+"]ʵ�������Ӧ��Ӱ����Ϣ��",ErrorTypes.PesistentError);
			}
			return cm;
		}
		


		/// <summary>
		/// DataBase������ ��ʼ
		/// tintown add at 2004-10-24
		/// </summary>
	

		//�������ݿ�������һ��RelationalDatabase
		internal RelationalDatabase GetDatabase(string name)
		{
			RelationalDatabase rdb;
			rdb=(RelationalDatabase)this.DatabasePool[name];
			if(!this.DatabasePool.Contains(name))
			{
				throw new PlException("δ�ҵ���Ϊ"+name+"��Ӧ���ݿ���Ϣ��",ErrorTypes.PesistentError);
			}
			return rdb;
		}
		private RelationalDatabase GetDatabase()
		{
			RelationalDatabase rdb;
			IEnumerator myEnumerator = DatabasePool.Values.GetEnumerator();
			myEnumerator.MoveNext();
			rdb=(RelationalDatabase)myEnumerator.Current;
			return rdb;
		}

		//�������ݿ�������һ��RelationalDatabase
		internal RelationalDatabase GetDatabaseCopy(string name)
		{
			RelationalDatabase rdb;
			rdb=(RelationalDatabase)this.DatabasePool[name];
			if(!this.DatabasePool.Contains(name))
			{
				throw new PlException("δ�ҵ���Ϊ"+name+"��Ӧ���ݿ���Ϣ��",ErrorTypes.PesistentError);
			}
			rdb=rdb.GetCopy();
			return rdb;
		}

		/// <summary>
		/// ׷����������
		/// add by tintown
		/// </summary>
		/// <param name="name"></param>
		/// <param name="DatabaseType"></param>
		/// <param name="connectionString"></param>
		internal void AppendDatabase(string name,string DatabaseType,string connectionString)
		{

			if(!this.DatabasePool.Contains(name))
			{
				RelationalDatabase rdb=null;
				try
				{
					rdb = (RelationalDatabase)this.GetType().Assembly.CreateInstance (DatabaseType);
					if (rdb == null) throw new Exception();
				}
				catch
				{
					string error = "��������Ϊ��" + DatabaseType + "�����ݿ����";
					throw new PlException (error,ErrorTypes.XmlError);
				}

				rdb.Name=name;
				//rdb.ConnectionString=connectionString;
				rdb.Initialize(connectionString);

				if (rdb!=null) this.DatabasePool.Add(rdb.Name,rdb);

				if (this.DatabasePool.Count > 1) this.MultiDatabase = true;

				//����Setting�е����ݿ�����
				Setting.Instance().SetConnectionString(rdb.Name,rdb.ConnectionString);
				XmlConfigLoader.Instance().DatabaseMaps.Add(rdb.Name,new DatabaseMap(rdb.Name));
			}
		}

		/// <summary>
		/// ׷���������Ӳ�����ָ����ClassMap�ļ���Ϣ
		/// </summary>
		/// <param name="name"></param>
		/// <param name="DatabaseType"></param>
		/// <param name="connectionString"></param>
		/// <param name="classMapPath"></param>
		internal void AppendDatabase(string name,string DatabaseType,string connectionString,string classMapPath)
		{

			if(!this.DatabasePool.Contains(name))
			{
				RelationalDatabase rdb=null;
				try
				{
					rdb = (RelationalDatabase)this.GetType().Assembly.CreateInstance (DatabaseType);
					if (rdb == null) throw new Exception();
				}
				catch
				{
					string error = "��������Ϊ��" + DatabaseType + "�����ݿ����";
					throw new PlException (error,ErrorTypes.XmlError);
				}

				rdb.Name=name;
				//rdb.ConnectionString=connectionString;
				rdb.Initialize(connectionString);

				if (rdb!=null) this.DatabasePool.Add(rdb.Name,rdb);

				if (this.DatabasePool.Count > 1) this.MultiDatabase = true;

				//����Setting�е����ݿ�����
				Setting.Instance().SetConnectionString(rdb.Name,rdb.ConnectionString);
				XmlConfigLoader.Instance().DatabaseMaps.Add(rdb.Name,new DatabaseMap(rdb.Name));

				

			}
			//����ClassMap��Ϣ
			XmlConfigLoader.Instance().LoadClassMapInformation(classMapPath);
		}


		internal void LoadClassMap(string classMapPath)
		{
			//����ClassMap��Ϣ
			XmlConfigLoader.Instance().LoadClassMapInformation(classMapPath);
		}

		/// <summary>
		/// DataBase ����������
		/// </summary>
	

		
		//����һ��ʵ�����
		public EntityObject GetEntityObject(Type classType,string className,DataRow row)
		{
			EntityObject aObject=null;
			aObject=(EntityObject)classType.Assembly.CreateInstance(classType.ToString());
			ClassMap cm=(ClassMap)this.ClassMaps[className];
			cm.SetObject(aObject,row);
			return aObject;
		}

		
		/// <summary>
		/// ����һ������(ֻ�����ڵ����ݿ�)
		/// add by tintown at 2004-09-06
		/// ���ִ��SQL����������
		/// ���ڿ��Խ��������������ݿ����ӣ������������У�������MultiDatabase�ķ�����
		/// �˷�����ʱ��Ч
		/// </summary>
		/// <param name="tran"></param>
		public void ProcessTransactionSingleDatabase(Transaction tran)
		{
			RelationalDatabase rdb;
			object obj=null;

			rdb=this.GetDatabase();
			rdb=rdb.GetCopy();
			try
			{
				rdb.Open();
				rdb.BeginTransaction();
				for(int i=0;i<tran.Tasks.Count;i++)
				{
					obj=tran.Tasks[i];
					switch ((ActionTypes)tran.Actions[i])
					{
						case ActionTypes.DeleteCommand:
							this.DeleteObject((EntityObject)obj,rdb);
							break;
						case ActionTypes.InsertCommand:
							this.SaveObject((EntityObject)obj,rdb);
							break;
						case ActionTypes.UpdateCommand:
							this.SaveObject((EntityObject)obj,rdb);
							break;
						case ActionTypes.PesistentCriteria:
							this.ProcessCriteria ((PersistentCriteria)obj,rdb);
							break;
						case ActionTypes.SelectCommand:
							this.RetrieveObject( (EntityObject)obj,rdb);
							break;
						case ActionTypes.SqlCommand:
							this.ExecuteSql(((Hashtable)obj)["String"].ToString(),rdb);
							break;
						default:
							break;
					}
				}
				rdb.CommitTransaction();
			}
			catch(Exception e)
			{
				rdb.RollbackTransaction();
				if (obj is EntityObject) 
					this.ErrorHandle(e,(EntityObject)obj);
				else
					this.ErrorHandle (e,null);
			}	
			finally
			{
				rdb.Close();
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="rc"></param>
		public DataTable ProcessRetrieveCriteria(RetrieveCriteria rc)
		{
			if(rc.DatabaseName==null)
				rc.DatabaseName=rc.classMap.Database.Name;

			RelationalDatabase rdb;
			if(rc.Rdb!=null)
				rdb=rc.Rdb;
			else
                rdb=this.GetDatabaseCopy(rc.DatabaseName);
			IDbCommand  cmd = rdb.GetCommand();
			rc.BuildStringForRetrieve ();

			if(rc.IsSaveInMemory)
			{
				if(GlobalCacheControl.Instance().Contains(rc.MemoryKey))
				{
					DataTable dt=GlobalCacheControl.Instance().GetEntityContainer(rc.MemoryKey);
					int whereInd=rc.SqlString.LastIndexOf("WHERE");
					int orderInd=rc.SqlString.LastIndexOf("ORDER BY");
					string where="";
					string order="";
					if(whereInd!=-1)
					{
						where=rc.SqlString.Substring(whereInd+5).Replace(rc.classMap.Table.Name+".","");
					}
					if(orderInd!=-1)
					{
						if(where!="")
							where=where.Substring(0,where.LastIndexOf("ORDER BY"));
						order=rc.SqlString.Substring(orderInd+9).Replace(rc.classMap.Table.Name+".","");
					}
					
					//					DataView dv=new DataView(dt,where,order,DataViewRowState.None);
					//
					//					DataTable dt2=dv.Table.Copy();

					DataRow[] drs=dt.Select(where,order);
					DataTable dt2=dt.Copy();
					dt2.Rows.Clear();
					foreach(DataRow row in drs)
					{
						
						DataRow row2=dt2.NewRow();
						for(int i=0;i<row2.Table.Columns.Count;i++)
							row2[i]=row[i];
						dt2.Rows.Add(row2);
					}
					return dt2;
				}
				else
				{
					//��ӵ��ڴ���begin\

					SaveToMemory(rc.MemoryKey,rc.classMap,rdb);

//					int x=this._sqlString.LastIndexOf("WHERE");
//					cmd.CommandText=this._sqlString;
//					if(x!=-1)
//						cmd.CommandText = this._sqlString.Substring(0,this._sqlString.LastIndexOf("WHERE"));
//					DataTable dt=_broker.ExecuteQuery(cmd,_databaseName);
//									
//					GlobalCacheControl.Instance().Add(this.MemoryKey,dt);


					//��ӵ��ڴ���end

					//����Datatable
					cmd.CommandText=rc.SqlString;
					return rdb.AsDataTable(cmd);
					

				}
				
			}
			else
			{
				
				cmd.CommandText = rc.SqlString;
				if(rc.Top==0)
					return rdb.AsDataTable(cmd);
				else
					return rdb.AsDataTable(cmd,rc.Top);
			}
		}

		

		//����һ������(���ö�����ݿ�)
		/// <summary>
		/// ��������ݿ��������
		/// add by tintown at 2004-09-06
		/// ����SQL��������
		/// </summary>
		/// <param name="tran"></param>
		public bool ProcessTransactionMultiDatabases (Transaction tran)
		{
			bool roolback=false;
			Hashtable databases = new Hashtable ();
			RelationalDatabase rdb = null;
			EntityObject eobj = null;
			PersistentCriteria c = null;
			ActionTypes actionType ;
			string dbName ;
			string className;
			ClassMap cm;
			//Add by tintown �ӣѣ��������ݿ���
			Hashtable htsqlstring;
			string sqlstring="";
			//���ڴ����Щ�豣�浽�ڴ��������������RoolBackʱ���Խ������
			ArrayList saveToMemoryList=new ArrayList();
		
			try
			{
				for(int i=0;i<tran.Tasks.Count;i++)
				{
					actionType = (ActionTypes)tran.Actions[i];
					if(actionType == ActionTypes.PesistentCriteria)
					{
						c = (PersistentCriteria) (tran.Tasks[i]) ;
						className = EntityObject.GetClassName (c.ForClass);
						cm=this.GetClassMap(className);
						//�����Ҫ���浽�ڴ棬����ӵ��ع��ڴ��б���tintown added at 2005-3-23
						if(c.IsSaveInMemory)
                            saveToMemoryList.Add(c.MemoryKey);

						if(c.DatabaseName==null)
						{
							dbName = cm.Database.Name;
							c.DatabaseName=dbName;
						}else
							dbName=c.DatabaseName;
						
												
					}
					else if(actionType==ActionTypes.SqlCommand)
					{
						htsqlstring=(Hashtable)(tran.Tasks[i]);
						dbName = htsqlstring["DB"].ToString();
						sqlstring=htsqlstring["String"].ToString();
						
					}
					else
					{
						eobj = (EntityObject) (tran.Tasks [i]);
						cm=this.GetClassMap(eobj.GetClassName ());
						//���������Ҫ���浽�ڴ�ģ��ͼӵ��ع��ڴ��б���
						if(eobj.IsSaveToMemory)
							saveToMemoryList.Add(eobj.MemoryKey);
							
						//tintown add at 2004-10-23
						//�������У������ʵ��Ļ���ҲҪȡʵ���Լ�������Դ
						if(eobj.DatabaseName==null)
						{
							dbName = cm.Database.Name;
							eobj.DatabaseName=dbName;
						}
						else
							dbName = eobj.DatabaseName;
					}
					rdb = (RelationalDatabase) databases[dbName];
					if (rdb == null)
					{
						rdb = this.GetDatabase (dbName).GetCopy ();
						databases.Add (dbName,rdb);
						rdb.Open ();
						rdb.BeginTransaction ();
					}
					switch (actionType)
					{
						case ActionTypes.DeleteCommand:
							if(this.DeleteObject(eobj,rdb)<=0 && !tran.IsForceCommit)
								{roolback=true;goto RollBackPoint;}
							break;
						case ActionTypes.InsertCommand:
							if(this.SaveObject(eobj,rdb)<=0 && !tran.IsForceCommit)
							{roolback=true;goto RollBackPoint;}
							break;
						case ActionTypes.UpdateCommand:
							if(this.SaveObject(eobj,rdb)<=0 && !tran.IsForceCommit)
							{roolback=true;goto RollBackPoint;}
							break;
						case ActionTypes.PesistentCriteria:
							this.ProcessCriteria (c,rdb);
							//this.ProcessDeleteCriteria(c,rdb);
							break;
						case ActionTypes.SelectCommand:
							this.RetrieveObject( eobj,rdb);
							break;
						case ActionTypes.SqlCommand :
							this.ExecuteSql(sqlstring,rdb);
							break;
						default:
							break;
					}
				}

				//��ǰ����������ɹ�ʱ��ֱ�������˴�����roolback������Ҫ���ύ����������
			RollBackPoint:

				//�ύ��������
				if(!roolback)
				{
					foreach (RelationalDatabase r in databases.Values)
					{
						r.CommitTransaction ();
					}

				}
				else
				{
					//�����ڻع���ͬʱ��Ҫ�ѱ��浽�ڴ�����
					foreach (RelationalDatabase r in databases.Values)
					{
						r.RollbackTransaction ();
					}
					
					//����ڴ��е����ݣ������ݵ�ʱ���°��ڴ�
					for(int i=0;i<saveToMemoryList.Count;i++)
					{
						GlobalCacheControl.Instance().RemoveIt(saveToMemoryList[i].ToString());
					}

//					throw(new PlException("�������и�������Ϊ��Ĳ����������ǲ�������.",ErrorTypes.DirtyEntity));

				}
				
				
			}
			catch (Exception e)
			{
				//�ع���������
				foreach (RelationalDatabase r in databases.Values)
				{
					r.RollbackTransaction ();
				}

				//����ڴ��е����ݣ������ݵ�ʱ���°��ڴ�
				for(int i=0;i<saveToMemoryList.Count;i++)
				{
					GlobalCacheControl.Instance().RemoveIt(saveToMemoryList[i].ToString());
				}

				//if (actionType == obj is EntityObject) this.ErrorHandle(e,(EntityObject)obj);
				throw e;
			}
			finally
			{
				//�ر���������
				foreach (RelationalDatabase r in databases.Values)
				{
					r.Close ();
				}
			}
			return !roolback;
		}


		/// <summary>
		/// ��������ִ�в�ѯSQL���
		/// </summary>
		/// <param name="htSql">���</param>
		/// <param name="rdbs">���Ӽ�</param>
		/// <returns></returns>
		internal DataTable DoQueryTransaction(Hashtable htSql,Hashtable rdbs)
		{
			Hashtable htsqlstring=htSql;
			string dbName=htSql["DB"].ToString();
			string sqlstring=htSql["String"].ToString();
			RelationalDatabase rdb = null;
			try
			{
				//������
				if(rdbs.Contains(dbName))
					rdb=(RelationalDatabase)rdbs[dbName];
				else
				{
					rdb=this.GetDatabase(dbName).GetCopy();
					rdbs.Add(dbName,rdb);
					rdb.Open();
					rdb.BeginTransaction();
					
				}
				IDbCommand cmd = GetCommand (dbName);
				cmd.CommandText = sqlstring;
				return rdb.AsDataTable(cmd);
			}
			catch(Exception e)
			{

				foreach (string key in rdbs.Keys)
				{
					rdb=(RelationalDatabase)rdbs[key];
					rdb.RollbackTransaction();
					rdb.Close();
				}
				throw e;
			}
		}

		/// <summary>
		/// ����ִ������Ĳ���
		/// </summary>
		/// <param name="obj">����</param>
		/// <param name="actionType">����</param>
		/// <param name="rdbs">���Ӽ�</param>
		/// <param name="isForceCommit">ǿ��ִ��</param>
		internal void DoTransaction(object obj,ActionTypes actionType,Hashtable rdbs,bool isForceCommit)
		{
			EntityObject eobj=null;
			ClassMap cm=null;
			string dbName=null;
			string className;
			PersistentCriteria c = null;
			RelationalDatabase rdb = null;
			RetrieveCriteria rc=null;
			string sqlstring="";
			try
			{
			
				if(actionType==ActionTypes.PesistentCriteria)
				{
					c=(PersistentCriteria)obj;
					className=EntityObject.GetClassName(c.ForClass);
					cm=this.GetClassMap(className);
					if(c.DatabaseName==null)
					{
						dbName=cm.Database.Name;
						c.DatabaseName=dbName;
					}
					else
					{
						dbName=c.DatabaseName;
					}
				}
				else if(actionType==ActionTypes.SqlCommand)
				{
					Hashtable htsqlstring=(Hashtable)obj;
					dbName=htsqlstring["DB"].ToString();
					sqlstring=htsqlstring["String"].ToString();
				}
				else
				{
					eobj=(EntityObject)obj;
					cm=this.GetClassMap(eobj.GetClassName());
					if(eobj.DatabaseName==null)
					{
						dbName=cm.Database.Name;
						eobj.DatabaseName=dbName;
					}
					else
						dbName=eobj.DatabaseName;
				}

				//������
				if(rdbs.Contains(dbName))
					rdb=(RelationalDatabase)rdbs[dbName];
				else
				{
					rdb=this.GetDatabase(dbName).GetCopy();
					rdbs.Add(dbName,rdb);
					rdb.Open();
					rdb.BeginTransaction();
					
				}

				switch (actionType)
				{
					case ActionTypes.SelectCommand:
						this.RetrieveObject(eobj,rdb);
						break;
					case ActionTypes.DeleteCommand:
						if(this.DeleteObject(eobj,rdb)<=0 && !isForceCommit)
						{
							throw new PlException("���ڲ�����������������ύ.",ErrorTypes.DirtyEntity);
							
						}
						else
						{
							//����ɹ��ˣ�������ڴ�ӳ��ģ�����ڴ����������Ը�Ժ���������
							if(eobj.IsSaveToMemory)
								GlobalCacheControl.Instance().RemoveIt(eobj.MemoryKey);
							
						}
						break;
					case ActionTypes.InsertCommand:
					case ActionTypes.UpdateCommand:
						if(this.SaveObject(eobj,rdb)<=0 && !isForceCommit)
						{
							throw new PlException("���ڲ�����������������ύ.",ErrorTypes.DirtyEntity);
							
						}
						else
						{
							//����ɹ��ˣ�������ڴ�ӳ��ģ�����ڴ����������Ը�Ժ���������
							if(eobj.IsSaveToMemory)
								GlobalCacheControl.Instance().RemoveIt(eobj.MemoryKey);
							
						}
						break;
					case ActionTypes.PesistentCriteria:
						this.ProcessCriteria(c,rdb);
						break;
					case ActionTypes.SqlCommand:
						this.ExecuteSql(sqlstring,rdb);
						break;
				}
			}
			catch(Exception e)
			{

				foreach (string key in rdbs.Keys)
				{
					rdb=(RelationalDatabase)rdbs[key];
					rdb.RollbackTransaction();
					rdb.Close();
				}
				throw e;
			}
			

		}

		/// <summary>
		/// ��������ִ�л�ȡ��׼
		/// </summary>
		/// <param name="obj">��׼</param>
		/// <param name="rdbs">���Ӽ�</param>
		/// <returns></returns>
		public DataTable DoRetrieveCriteraTransaction(object obj,Hashtable rdbs)
		{
			RetrieveCriteria rc=(RetrieveCriteria)obj;
			string className=EntityObject.GetClassName(rc.ForClass);
			ClassMap cm=this.GetClassMap(className);
			string dbName;
			RelationalDatabase rdb=null;
			try
			{
				if(rc.DatabaseName==null)
				{
					dbName=cm.Database.Name;
					rc.DatabaseName=dbName;
				}
				else
				{
					dbName=rc.DatabaseName;
				}

				//������
				if(rdbs.Contains(dbName))
					rdb=(RelationalDatabase)rdbs[dbName];
				else
				{
					rdb=this.GetDatabase(dbName).GetCopy();
					rdbs.Add(dbName,rdb);
					rdb.Open();
					rdb.BeginTransaction();
					
				}
				rc.Rdb=rdb;
				return ProcessRetrieveCriteria(rc);
			}
			catch(Exception e)
			{

				foreach (string key in rdbs.Keys)
				{
					rdb=(RelationalDatabase)rdbs[key];
					rdb.RollbackTransaction();
					rdb.Close();
				}
				throw e;
			}
		}


		/// <summary>
		///		����ʵ������������ݿ���
		/// </summary>
		public string GetDatabaseName(EntityObject obj)
		{
			ClassMap cm=this.GetClassMap(obj.GetClassName());
			return cm.Database.Name;			
		}

		/// <summary>
		///		����DeleteCriteria,UpdateCriteria
		/// </summary>
		/// <param name="criteria">��Ӧ��PesistentCriteria</param>
		/// <returns>��Ӱ�������</returns>
		public int ProcessCriteria(PersistentCriteria criteria)
		{
			
			RelationalDatabase rdb;
			IDbCommand  cmd;
			int infect;

			switch (criteria.CriteriaType)
			{
				case CriteriaTypes.Update:
					//ȡ��criteria��Ӧ��UpdateCriteria
					UpdateCriteria uCriteria = (UpdateCriteria) criteria;
					rdb=this.GetDatabase(uCriteria.DatabaseName).GetCopy();
					rdb.Open();
					cmd = rdb.GetCommand();
					uCriteria.BuildStringForUpdate();
					cmd.CommandText=uCriteria.SqlString;
					Hashtable ht=uCriteria.ForUpdateCollection;
					if(ht.Count<=0)
						return 0;
					foreach(object key in ht.Keys)
					{
						IDataParameter p= cmd.CreateParameter();
						if(rdb.Vendor==DatabaseVendor.MySql)
							p.ParameterName="?"+ key.ToString();
						else
							p.ParameterName = "@" +  key.ToString();
						
						p.DbType=uCriteria.classMap.GetAttributeMap(key.ToString()).Column.Type;										//������				
						p.Value=ht[key.ToString()].ToString();
						cmd.Parameters.Add (p);
					}

//					//tintown added at 2005-3-22 ��Ӷ�timestamp�ĸ��²���
					//ȡ���˸��±�׼��timestamp�ĸ���
//					if(uCriteria.classMap.TimestampAttribute!=null)
//					{
//						ColumnMap cm=uCriteria.classMap.TimestampAttribute.Column;
//						IDataParameter p= cmd.CreateParameter();
//						//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����												//����
//						p.ParameterName = "@Update" + cm.Name;
//						p.DbType=cm.Type;										//������				
//						p.Value=DateTime.Now.Ticks;	   			//��timestamp��now��ticks����һ������
//						cmd.Parameters.Add (p);
//					}

					

					try
					{
						infect=rdb.DoCommand(cmd);
						if(infect>0 && uCriteria.IsSaveInMemory)
						{
							SaveToMemory(uCriteria.MemoryKey,this.GetClassMap(uCriteria.classMap.Name),rdb);
		
						}
						rdb.Close();
						return infect;	
					}
					catch(Exception e)
					{
						string s="";
						ErrorTypes error=rdb.ErrorHandler (e,out s);
						throw new PlException(s,error);
					}


//					cursor = uCriteria.Retrieve.AsCursor ();
//					while (cursor.HasObject())
//					{
//						obj = cursor.NextObject();
//						int l = uCriteria.ForUpdateCollection.Count;
//						for (int i = 0;i < l;i ++)
//						{
//							obj.SetAttributeValue (uCriteria.ForUpdateCollection[i].ToString(),
//								uCriteria.ForUpdateCollection[++i]);
//						}
//						this.SaveObject (obj);
//					}
//					return cursor.Count;
					
					//����ɾ����׼
				default:
					//ȡ��criteria��Ӧ��DeleteCriteria
					DeleteCriteria dCriteria = (DeleteCriteria) criteria;
					
					rdb=this.GetDatabase(dCriteria.DatabaseName).GetCopy();
					rdb.Open();
					cmd = rdb.GetCommand();
					dCriteria.BuildStringForDelete();
		
					cmd.CommandText=dCriteria.SqlString;
					try
					{
						infect=rdb.DoCommand(cmd);
						if(infect>0 && dCriteria.IsSaveInMemory)
						{
							SaveToMemory(dCriteria.MemoryKey,this.GetClassMap(dCriteria.classMapName),rdb);
		
						}
						rdb.Close();
						return infect;	
					}
					catch(Exception e)
					{
						string s="";
						ErrorTypes error=rdb.ErrorHandler (e,out s);
						throw new PlException(s,error);
					}
					
					
			}
		}
		
		/// <summary>
		///		�������д���DeleteCriteria,UpdateCriteria
		/// </summary>
		/// <param name="criteria">��Ӧ��PesistentCriteria</param>
		/// <param name="rdb">��Ҫ����ʵ������������ݿ�</param>
		/// <returns>��Ӱ�������</returns>
		public int ProcessCriteria(PersistentCriteria criteria ,RelationalDatabase rdb)
		{
			
			
			IDbCommand  cmd;
			int infect;

			switch (criteria.CriteriaType)
			{
				case CriteriaTypes.Update:
					UpdateCriteria uCriteria = (UpdateCriteria) criteria;
					cmd = rdb.GetCommand();
					uCriteria.BuildStringForUpdate();
					cmd.CommandText=uCriteria.SqlString;
					Hashtable ht=uCriteria.ForUpdateCollection;
					if(ht.Count<=0)
						return 0;
					foreach(object key in ht.Keys)
					{
						IDataParameter p= cmd.CreateParameter();
						if(rdb.Vendor==DatabaseVendor.MySql)
                            p.ParameterName = "?" + key.ToString();
						else
							p.ParameterName = "@" + key.ToString();
						p.DbType=uCriteria.classMap.GetAttributeMap(key.ToString()).Column.Type;										//������				
						p.Value=ht[key.ToString()].ToString();
						cmd.Parameters.Add (p);
					}

//					//tintown added at 2005-3-22 ��Ӷ�timestamp�ĸ��²���
					//ȡ���˸��±�׼ ��timestamp��ֵ����
//					if(uCriteria.classMap.TimestampAttribute!=null)
//					{
//						ColumnMap cm=uCriteria.classMap.TimestampAttribute.Column;
//						IDataParameter p= cmd.CreateParameter();
//						//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����												//����
//						p.ParameterName = "@Update" + cm.Name;
//						p.DbType=cm.Type;										//������				
//						p.Value=DateTime.Now.Ticks;	   			//��timestamp��now��ticks����һ������
//						cmd.Parameters.Add (p);
//					}
					
					

					try
					{
						infect=rdb.DoCommand(cmd);
						if(infect>0 && uCriteria.IsSaveInMemory)
						{
							SaveToMemory(uCriteria.MemoryKey,this.GetClassMap(uCriteria.classMap.Name),rdb);
		
						}
						return infect;	
					}
					catch(Exception e)
					{
						string s="";
						ErrorTypes error=rdb.ErrorHandler (e,out s);
						throw new PlException(s,error);
					}
					//����ɾ����׼
				default:
					//ȡ��criteria��Ӧ��DeleteCriteria
					DeleteCriteria dCriteria = (DeleteCriteria) criteria;
				
					cmd = rdb.GetCommand();
					dCriteria.BuildStringForDelete();
		
					cmd.CommandText=dCriteria.SqlString;
					try
					{
						infect=rdb.DoCommand(cmd);
						if(infect>0 && dCriteria.IsSaveInMemory)
						{
							SaveToMemory(dCriteria.MemoryKey,this.GetClassMap(dCriteria.classMapName),rdb);
		
						}
						return infect;	
					}
					catch(Exception e)
					{
						string s="";
						ErrorTypes error=rdb.ErrorHandler (e,out s);
						throw new PlException(s,error);
					}
								
			}
		}

		
		
		//����һ��ʵ�����
		public int SaveObject(EntityObject obj)
		{
			int result=0;
			ClassMap cm=this.GetClassMap(obj.GetClassName());
			//RelationalDatabase rdb = cm.RelationalDatabase.GetCopy ();
			RelationalDatabase rdb;
			//tintown add at 2004-10-23
			//�ж����ʵ������ݿ�����Ϊnull����ʹ��ʵ������ݿ�����
			if(obj.DatabaseName==null)
			{
				rdb = cm.RelationalDatabase.GetCopy ();
				obj.DatabaseName=cm.Database.Name;
			}
			else
			{
				rdb=this.GetDatabase(obj.DatabaseName).GetCopy();
			}
			try
			{
				rdb.Open();
				if(cm.HasAssociation()) rdb.BeginTransaction();
				result=this.SavePrivate(obj,cm,rdb);
				if(cm.HasAssociation()) rdb.CommitTransaction();
				
			}
			catch(Exception e)
			{
				if (cm.HasAssociation()) rdb.RollbackTransaction();
				this.ErrorHandle(e,obj);
				//throw e;
			}
			finally
			{
				rdb.Close();
			}

			return result;
		}
		//����һ��ʵ�����(��������)
		public int SaveObject(EntityObject obj,RelationalDatabase rdb)
		{
			ClassMap cm=this.GetClassMap(obj.GetClassName());
			return this.SavePrivate(obj,cm,rdb);
		}
		
		private int SavePrivate(EntityObject obj,ClassMap cm,RelationalDatabase rdb)
		{
			int result=0;
			/*����Associations*/
			if(cm.HasAssociation())
			{
				int i;
				int c=cm.Associations.Count;
				Association a;
				EntityObject aObject;
				ClassMap clsMap;

				for(i=0;i<c;i++)
				{
					a=(Association)cm.Associations[i];
					if (!a.SaveAutomatic) break;
					if(a.Cardinality==CardinalityTypes.OneToOne)
					{
						aObject=(EntityObject)obj.GetAttributeValue(a.Target);
						if (aObject==null)break;
						clsMap=this.GetClassMap(aObject.GetClassName());
						this.SavePrivate(aObject,clsMap,rdb);
					}
					else
					{
						EntityObjectCollection col=(EntityObjectCollection)obj.GetAttributeValue(a.Target);
						if (col==null) break;
						for(int j=0;j<col.Count;j++)
						{
							aObject=(EntityObject)col.Objects[j];
							clsMap=this.GetClassMap(aObject.GetClassName());							
							this.SavePrivate(aObject,clsMap,rdb);
						}
					}
				}

			}
			//���������
			IDbCommand cmd;
			if(obj.IsPersistent)
			{
				
				//Update

//				if(!(obj.DirtyCode==DirtyControl.Instance().GetDirtyCode(obj.DirtyKey)))
//				{
//					throw new PlException("�����Ѿ�������",ErrorTypes.DirtyEntity);
//				}else
//					obj.DirtyCode=DirtyControl.Instance().ResetDirtyCode(obj.DirtyKey);
				
				//do
				//{
					cmd = cm.GetUpdateSqlFor (obj);
				result=rdb.DoCommand (cmd);
//					if (rdb.DoCommand (cmd) < 1)
//					{
//						throw new PlException ("��" + obj.GetClassName () + "�������ʧ�ܣ�",ErrorTypes.UpdateFail);
//					}
				//	cm = cm.SuperClass;
				//}while (cm != null);

				if(obj.IsSaveToMemory && result>0)
                    SaveToMemory(obj.MemoryKey,cm,rdb);
				

			}
			else
			{
				//Insert
				//do
				//{
					cmd = cm.GetInsertSqlFor (obj);
					if (cm.Table.AutoIdentityIndex < 0)
					{
						result=rdb.DoCommand(cmd);
					}
						//���ñ���Identity��
					else
					{
						object id;
						result=rdb.InsertRecord (cmd, out id);

						obj.SetAttributeValue (cm.AutoIdentityAttribute,id);
					}
					//cm = cm.SuperClass;
				//}while (cm != null);

				if(obj.IsSaveToMemory && result>0)
                    SaveToMemory(obj.MemoryKey ,cm,rdb);
			}

			return result;
		}

		//		public void test()
		//		{
		//			foreach (RelationalDatabase rdb in this.DatabasePool.Values)
		//			{
		//				Console.WriteLine(rdb.Name);
		//			}
		//		}

		//����һ��ɾ����׼
		//		public int ProcessDeleteCriteria(DeleteCriteria aCriteria)
		//		{
		//			string name=EntityObject.GetClassName(aCriteria.ForClass);
		//			ClassMap cm=this.GetClassMap(name);
		//			RelationalDatabase rdb=this.GetDatabaseCopy(cm.Database.Name);
		//			rdb.Open();
		//			IDbCommand cmd=cm.GetDeleteSqlFor(aCriteria);
		//			int result=rdb.DoCommand(cmd);
		//			rdb.Close();
		//			return result;
		//		}
		//		public int ProcessDeleteCriteria(DeleteCriteria aCriteria,RelationalDatabase rdb)
		//		{
		//			aCriteria.Criteria.Perform();
		//			string name=EntityObject.GetClassName(aCriteria.ForClass);
		//			ClassMap cm=this.GetClassMap(name);
		//			IDbCommand cmd=cm.GetDeleteSqlFor(aCriteria);
		//			int result=rdb.DoCommand(cmd);
		//			return result;
		//		}


		//�����ؼ�¼��Command�Ĵ���
		public int Execute(string dbName,IDbCommand cmd)
		{
			RelationalDatabase rdb=null;
			rdb=this.GetDatabase (dbName).GetCopy();
			rdb.Open();
			int r=rdb.DoCommand(cmd);
			rdb.Close();
			return r;
		}
		
		private void ErrorHandle(Exception e,EntityObject obj)
		{
			if (e is PlException )
			{
				throw e;
			}

			if (obj == null)
			{
				throw new PlException (e.Message,ErrorTypes.DatabaseUnknwnError);
			}

			RelationalDatabase rdb = this.GetDatabase(GetDatabaseName(obj));
			
			string s="";
			ErrorTypes error = rdb.ErrorHandler (e,out s);

			//����������ݿ�Ĵ���
			if (error == ErrorTypes.Unknown)
			{
				//���������ת���쳣
				if (e is InvalidCastException)
				{
					switch (e.TargetSite.Name )
					{
						case "RetrievePrivate":
							s = obj.GetClassName () + "������ִ��Retrive()����ʱ������������ת���쳣������������ļ����ԣ�";
							throw new PlException (s);
					}
				}
				throw new PlException (e.Message,ErrorTypes.Unknown);
				
			}
				//�������ݿ����
			else
			{
				switch(error)
				{
					case ErrorTypes.NotUnique:
						s = "��ʶ,����"+obj.GetClassName()+"����������������������Ѵ������ݳ�ͻ��";
						throw new PlException (s,error);
					case ErrorTypes.DataTooLong:
						s = obj.GetClassName() + "����������������ĳЩ���Ե����ݳ������ݿ����ɷ�Χ��";
						throw new PlException (s,error);
					case ErrorTypes.NotAllowStringEmpty:
						s = "����" + obj.GetClassName() + "�������������ĳЩ��������Ϊstring�����Բ���Ϊ�㳤�ȣ�" + s;
						throw new PlException (s,error);
					case ErrorTypes.NotAllowDataNull:
						s = "����" + obj.GetClassName() + "�������������ĳЩ���Բ���ΪNull��" + s;
						throw new PlException (s,error);
					case ErrorTypes.DataTypeNotMatch:
						s = "����" + obj.GetClassName() + "�������������ĳЩ�����������������ݿ��������Ͳ����ݣ�";
						throw new PlException (s,error);
					case ErrorTypes.AutoValueOn:
						s = obj.GetClassName () + "�������������������Զ�������ԣ�����ָ���ض�ֵ��" + s;
						throw new PlException (s,error);
					case ErrorTypes.RestrictError:
						s = "��ͼ��" + obj.GetClassName() + "�������������Լ�����ƣ���������ֹ��" + s;
						throw new PlException (s,error);
					case ErrorTypes.RequireAttribute:
						s = "��ͼ��" + obj.GetClassName() + "�������������Ҫ������δָ����Ϊnull��" + s;
						throw new PlException (s,error);
				}
				//��������
				s = obj.GetClassName () + "������������ο���" + s;
				throw new PlException (s,error);
			}
		}


		/// <summary>
		/// ��̬�ĸ�ORACLE���TOP���ܵķ�������WHERE�����rownum
		/// </summary>
		/// <param name="sqlString"></param>
		/// <param name="top"></param>
		/// <returns></returns>
		internal static string AddOracleTopWhere(string sqlString,int top)
		{
			int whereInd=sqlString.LastIndexOf("WHERE");
			int orderInd=sqlString.LastIndexOf("ORDER BY");
			string where="";
			if(whereInd!=-1)
			{
				where=sqlString.Substring(whereInd+5);
				where =" rownum<="+top.ToString()+" and "+where;
				sqlString=sqlString.Substring(0,whereInd+5)+where;
			}
			else
			{
				if(orderInd!=-1)
				{
					sqlString=sqlString.Substring(0,orderInd)+ " WHERE rownum<="+top.ToString()+" "+sqlString.Substring(orderInd);
				}
				else
				{
					sqlString +=" WHERE rownum<="+top.ToString();
				}
			}

			return sqlString;
		}

		/// <summary>
		/// ��̬�ĸ�MySql���TOP���ܵķ���????
		/// </summary>
		/// <param name="sqlString"></param>
		/// <param name="top"></param>
		/// <returns></returns>
		internal static string AddMySqlTopWhere(string sqlString,int top)
		{
	
			sqlString +=" limit "+top.ToString();		

			return sqlString;
		}

		

	
	}

}
