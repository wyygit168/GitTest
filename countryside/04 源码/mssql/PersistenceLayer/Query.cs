using System;
using System.Data;
using System.Collections;
using System.Text;

namespace PersistenceLayer
{
	/// <summary>
	///		Query����RetrieveCriteria��һ����ǿ�ࡣ
	///		RetrieveCriteria������ɵĹ���������Query�����
	///		Query���Խ������ϲ�ѯ��ִ��Sql��䡢ִ�д洢���̵�
	/// </summary>
	public class Query
	{
		private ArrayList m_Conditions=new ArrayList();
		private ArrayList m_Querys=new ArrayList();
		private Query m_FatherQuery=null;
		
		private ClassMap queryClass=null;
		
		private string selectClause="";
		private string orderClause="";
		private string fromClause="";
		private string groupClause="";
		private string whereClause = "";

		private string sTemp ;
		private string endQuostationMarks;

		private string selectString = "SELECT ";
		private string _sqlString ;
		
		private int m_top=0;

		private string _databaseName;
		

		/// <summary>
		/// 	����һ��Queryʵ��
		/// </summary>
		/// <param name="className">EntityObject������</param>
		public Query(string className)
		{
			ClassMap cm=PersistenceBroker.Instance().GetClassMap(className);
			this.queryClass=cm;
			sTemp = " AS " + cm.RelationalDatabase.QuotationMarksStart;
			endQuostationMarks = cm.RelationalDatabase.QuotationMarksEnd;
		}
		
		/// <summary>
		///		����һ��Queryʵ��
		/// </summary>
		/// <param name="classType">EntityObject�����Typeʵ��</param>
		public Query(Type classType)
		{
			string className = EntityObject.GetClassName(classType);
			ClassMap cm=PersistenceBroker.Instance().GetClassMap(className);
			this.queryClass=cm;
			sTemp = " AS " + cm.RelationalDatabase.QuotationMarksStart;
			endQuostationMarks = cm.RelationalDatabase.QuotationMarksEnd;

		}

		/// <summary>
		///		����һ��Queryʵ��
		/// </summary>
		/// <param name="classType">EntityObject�����Typeʵ��</param>
		/// <param name="DatabaseName">���������ݿ�����ݿ���</param>
		public Query(Type classType,string DatabaseName)
		{
			string className = EntityObject.GetClassName(classType);
			ClassMap cm=PersistenceBroker.Instance().GetClassMap(className);
			this.queryClass=cm;
			sTemp = " AS " + cm.RelationalDatabase.QuotationMarksStart;
			endQuostationMarks = cm.RelationalDatabase.QuotationMarksEnd;
			this.DatabaseName=DatabaseName;

		}

		/// <summary>
		///		ִ�д洢����
		/// </summary>
		/// <param name="storeProcName">�洢������</param>
		/// <param name="param">�洢���������������</param>
		/// <param name="affected">�洢����Ӱ�������</param>
		/// <param name="dbName">���ݿ���</param>
		/// <returns>�洢���̵ķ��ش���</returns>
		public static int RunProcedure(string storeProcName,IDataParameter[] param,out int affected,string dbName)
		{
			int result;
			PersistenceBroker broker;
			
			broker=PersistenceBroker.Instance();
			IDbCommand cmd = Query.BuildQueryCommand(storeProcName,param,dbName);
			//���ӷ���ֵ����
			IDataParameter p = cmd.CreateParameter();
			p.Direction=ParameterDirection.ReturnValue;
			p.ParameterName = "ReturnValue";
			p.DbType = DbType.Int32;
			cmd.Parameters.Insert(0,p);

			affected = broker.Execute (dbName,cmd);
			p = (IDataParameter)cmd.Parameters["ReturnValue"];
			result= (int) p.Value;
			return result;
		}

		/// <summary>
		///		ִ�д洢����(����ָ���洢����Timeoutʱ��:0������Զ)
		/// </summary>
		/// <param name="storeProcName">�洢������</param>
		/// <param name="param">�洢���������������</param>
		/// <param name="affected">�洢����Ӱ�������</param>
		/// <param name="dbName">���ݿ���</param>
		/// <param name="commandTimeout">ִ��ʱ��(��)��Ĭ��Ϊ30,�����Ϊ0��������</param>
		/// <returns>�洢���̵ķ��ش���</returns>
		public static int RunProcedure(string storeProcName,IDataParameter[] param,out int affected,string dbName,int commandTimeout)
		{
			int result;
			PersistenceBroker broker;
			
			broker=PersistenceBroker.Instance();
			IDbCommand cmd = Query.BuildQueryCommand(storeProcName,param,dbName);
			cmd.CommandTimeout=commandTimeout;
			//���ӷ���ֵ����
			IDataParameter p = cmd.CreateParameter();
			p.Direction=ParameterDirection.ReturnValue;
			p.ParameterName = "ReturnValue";
			p.DbType = DbType.Int32;
			cmd.Parameters.Insert(0,p);

			affected = broker.Execute (dbName,cmd);
			p = (IDataParameter)cmd.Parameters["ReturnValue"];
			result= (int) p.Value;
			return result;
		}

		/// <summary>
		///		ִ�д洢����,����DataTable 
		/// </summary>
		/// <param name="storeProcName">�洢������</param>
		/// <param name="ps">�洢���������������</param>
		/// <param name="dbName">���ݿ���</param>
		/// <returns>�洢���̷��ص�DataTable</returns>
		public static DataTable RunProcedure(string storeProcName,IDataParameter[] ps,string dbName)
		{
			IDbCommand cmd = Query.BuildQueryCommand(storeProcName,ps,dbName);
			PersistenceBroker broker=PersistenceBroker.Instance();
			return broker.ExecuteQuery(cmd ,dbName);
		}

		/// <summary>
		///		ִ�д洢����,����DataTable (ָ��Commandִ��ʱ�䣬0��������)
		/// </summary>
		/// <param name="storeProcName">�洢������</param>
		/// <param name="ps">�洢���������������</param>
		/// <param name="dbName">���ݿ���</param>
		/// <param name="commandTimeout">timeout����</param>
		/// <returns>�洢���̷��ص�DataTable</returns>
		public static DataTable RunProcedure(string storeProcName,IDataParameter[] ps,string dbName,int commandTimeout)
		{
			IDbCommand cmd = Query.BuildQueryCommand(storeProcName,ps,dbName);
			cmd.CommandTimeout=commandTimeout;
			PersistenceBroker broker=PersistenceBroker.Instance();
			return broker.ExecuteQuery(cmd ,dbName);
		}



        /// <summary>
        ///	ִ�д洢����,����DataSet 
        /// </summary>
        /// <param name="storeProcName">�洢������</param>
        /// <param name="ps">�洢���������������</param>
        /// <param name="dbName">���ݿ���</param>
        /// <returns>�洢���̷��ص�DataSet</returns>
        public static DataSet RunProcedureToDateSet(string storeProcName, IDataParameter[] ps, string dbName)
        {
            IDbCommand cmd = Query.BuildQueryCommand(storeProcName, ps, dbName);
            PersistenceBroker broker = PersistenceBroker.Instance();
            return broker.ExecuteMultiQuery(cmd, dbName);
        }

        /// <summary>
        ///ִ�д洢����,����DataSet (ָ��Commandִ��ʱ�䣬0��������)
        /// </summary>
        /// <param name="storeProcName">�洢������</param>
        /// <param name="ps">�洢���������������</param>
        /// <param name="dbName">���ݿ���</param>
        /// <param name="commandTimeout">timeout����</param>
        /// <returns>�洢���̷��ص�DataSet</returns>
        public static DataSet RunProcedureToDateSet(string storeProcName, IDataParameter[] ps, string dbName, int commandTimeout)
        {
            IDbCommand cmd = Query.BuildQueryCommand(storeProcName, ps, dbName);
            cmd.CommandTimeout = commandTimeout;
            PersistenceBroker broker = PersistenceBroker.Instance();
            return broker.ExecuteMultiQuery(cmd, dbName);
        }
		



		/// <summary>
		/// 	ִ��Sql��䷵��DataTable
		/// </summary>
		/// <param name="sql">SQL���</param>
		/// <param name="dbName">���������ݿ���</param>
		/// <returns>SQL����ѯ�����</returns>
		public static DataTable ProcessSql(string sql,string dbName)
		{
			PersistenceBroker broker = PersistenceBroker.Instance();
			IDbCommand cmd = broker.GetCommand (dbName);
			cmd.CommandText = sql;
			return broker.ExecuteQuery(cmd,dbName);
		}


        /// <summary>
        ///  ִ��Sql��䷵��DataSet
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="dbName">���������ݿ���</param>
        /// <returns>SQL����ѯ�����</returns>
        public static DataSet ProcessMultiSql(string sql, string dbName)
        {
            PersistenceBroker broker = PersistenceBroker.Instance();
            IDbCommand cmd = broker.GetCommand(dbName);
            //cmd.CommandTimeout = 120;
            cmd.CommandText = sql;
            //Logger.Write(sql);   //add by duhu
            return broker.ExecuteMultiQuery(cmd, dbName);
        }
		
		/// <summary>
		/// 	ִ��Sql��䷵��Ӱ������
		/// </summary>
		/// <param name="sql">SQL���</param>
		/// <param name="dbName">���������ݿ���</param>
		/// <returns>SQL���Ӱ������</returns>
		public static int ProcessSqlNonQuery(string sql,string dbName)
		{
			PersistenceBroker broker = PersistenceBroker.Instance();
			IDbCommand cmd = broker.GetCommand (dbName);
			cmd.CommandText = sql;
			return broker.Execute(dbName,cmd);
		}
		
		/// <summary>
		///		����һ��IDataParameter,��SqlParameter,����OleDbParameter
		///		��databaseName��Ӧ���ݿ�����ݿ�����ȷ��
		/// </summary>
		/// <param name="databaseName">���ݿ���</param>
		/// <returns></returns>
		public static IDataParameter GetParameter (string databaseName)
		{
			PersistenceBroker broker = PersistenceBroker.Instance();
			return broker.GetCommand (databaseName).CreateParameter ();
		}

		//�����µ�Sql���������Ҫ�Ĳ�������IDbCommand.Parameters����
		private static IDbCommand BuildQueryCommand(string storedProcName,IDataParameter[] param,string dbName)
		{
			PersistenceBroker broker = PersistenceBroker.Instance();
			IDbCommand cmd = broker.GetCommand (dbName);
			cmd.CommandText = storedProcName;
			cmd.CommandType=CommandType.StoredProcedure;
			
			if (param != null) 
			{
				for (int i = 0; i < param.Length ;i++)
				{
					IDataParameter p = param[i];
					cmd.Parameters.Add(p);
				}
			}
			return cmd;
		}

		/*===========================ʵ������=====================================*/
		/// <summary>
		///		����һ����������� 
		/// </summary>
		/// <returns></returns>
		public Condition GetQueryCondition()
		{
			Condition c = new Condition (this.queryClass);
			this.m_Conditions.Add(c);
			return c;
		}

		/// <summary>
		/// ͷN������
		/// </summary>
		public int Top
		{
			set
			{
				this.m_top=value;
			}
			get
			{
				return this.m_top;
			}
		}

		/// <summary>
		///����һ�����ԣ�������������Ϊ����DataTable������
		/// </summary>
		/// <param name="attributeName"></param>
		public void AddAttribute(string attributeName)
		{
			AttributeMap am=this.queryClass.GetAttributeMap(attributeName,true);
			selectClause+=","+queryClass.GetFullyQualifiedName(am.Column.Name) + sTemp + am.Name + endQuostationMarks;
		}
		/// <summary>
		///		����һ������ ����asName��Ϊ����DataTable������ 
		/// </summary>
		public void AddAttribute(string attributeName,string asName)
		{
			AttributeMap am=this.queryClass.GetAttributeMap(attributeName,true);		
			selectClause+=","+queryClass.GetFullyQualifiedName(am.Column.Name) + sTemp + asName + endQuostationMarks;
		}

		/// <summary>
		/// ����ѡ�����е�����
		/// </summary>
		/// <param name="all"></param>
		public void AddAttribute(AttributeType all)
		{
			if(all==AttributeType.All)
			{
				AttributeMap am;
				for(int i=0;i<this.queryClass.Attributes.Count;i++)
				{
					am=this.queryClass.GetAttributeMap(i);
					selectClause+=","+queryClass.GetFullyQualifiedName(am.Column.Name) + sTemp + am.Name + endQuostationMarks;
				}
			}
		}
			   
		
		/// <summary>
		///		������ѡ������ָ�����Ե�Max
		/// </summary>
		/// <param name="attributeName">ȡMaxֵ��������</param>
		/// <param name="asName">����Maxֵ��DataTable�е�����</param>
		public void SelectMax(string attributeName,string asName)
		{
			AttributeMap am = this.queryClass.GetAttributeMap(attributeName);
			selectClause+=",MAX("+queryClass.GetFullyQualifiedName(am.Column.Name)+") " + sTemp + asName + endQuostationMarks;
		}

		/// <summary>
		///		������ѡ������ָ�����Ե�Countֵ
		/// </summary>
		/// <param name="attributeName">ȡCountֵ��������</param>
		/// <param name="asName">����Countֵ��DataTable�е�����</param>
		public void SelectCount(string attributeName,string asName)
		{
			AttributeMap am = this.queryClass.GetAttributeMap(attributeName);
			selectClause+=",COUNT("+queryClass.GetFullyQualifiedName(am.Column.Name)+") "+sTemp+asName  + endQuostationMarks;
		}

		/// <summary>
		///		������ѡ������ָ�����Ե�Sumֵ
		/// </summary>
		/// <param name="attributeName">ȡSumֵ��������</param>
		/// <param name="asName">����Sumֵ��DataTable�е�����</param>
		public void SelectSum(string attributeName,string asName)
		{
			AttributeMap am = this.queryClass.GetAttributeMap(attributeName);
			selectClause+=",SUM("+queryClass.GetFullyQualifiedName(am.Column.Name)+") "+sTemp+asName + endQuostationMarks;
		}

		/// <summary>
		///		������ѡ������ָ�����Ե�Avgֵ
		/// </summary>
		/// <param name="attributeName">ȡAvgֵ��������</param>
		/// <param name="asName">����Avgֵ��DataTable�е�����</param>
		public void SelectAvg(string attributeName,string asName)
		{
			AttributeMap am = this.queryClass.GetAttributeMap(attributeName);
			selectClause+=",AVG("+queryClass.GetFullyQualifiedName(am.Column.Name)+") "+sTemp+asName+ endQuostationMarks;
		}

		/// <summary>
		///		��ֵ����һ��Query�����
		/// </summary>
		/// <param name="fromAttribute"></param>
		/// <param name="q"></param>
		/// <param name="toAttribute"></param>
		public void AddJoinQuery(string fromAttribute,Query q,string toAttribute)
		{
			this.AddQueryIn(q);
			
			q.m_FatherQuery = this;

			ClassMap cm=q.QueryClassMap;
			AttributeMap amFrom=this.queryClass.GetAttributeMap(fromAttribute,false);
			AttributeMap amTo=cm.GetAttributeMap(toAttribute,false);
			
			this.m_Querys.AddRange(q.Querys);

			this.whereClause += " AND " + queryClass.GetFullyQualifiedName(amFrom.Column.Name ) + "=" 
				+ cm.GetFullyQualifiedName(amTo.Column.Name );
		}
		
		//����һ��������ѯ��
		private void AddQueryIn(Query q)
		{
			m_Querys.Add(q);
			if (this.m_FatherQuery != null)
			{
				this.m_FatherQuery.AddQueryIn (q);
			}
		}
		
		private string BuildForQuery(IDbCommand cmd)
		{
			string whereClause;

			fromClause = " FROM " + queryClass.RelationalDatabase.QuotationMarksStart+queryClass.Table.Name+queryClass.RelationalDatabase.QuotationMarksEnd;
			ClassMap cm = this.queryClass.SuperClass;
			while( cm != null)
			{
				fromClause += "," + queryClass.RelationalDatabase.QuotationMarksStart+cm.Table.Name+queryClass.RelationalDatabase.QuotationMarksEnd ;
				cm = cm.SuperClass;
			}

			whereClause = " WHERE "+ GetSqlForConditions () ;
			if (this.queryClass.SuperClass != null)
			{
				whereClause += " AND " + this.queryClass.StringForInherit;
			}
												  
			//orderClause = " ORDER BY ''"+orderClause;
			
			//����Sql���
			Query q;
			for(int j= 0;j<m_Querys.Count;j++)
			{
				q =(Query) m_Querys[j];
				//Select Clause
				selectClause += q.selectClause;
				//From Clause
				cm = q.queryClass;
				do
				{
					fromClause += "," + queryClass.RelationalDatabase.QuotationMarksStart+cm.Table.Name+queryClass.RelationalDatabase.QuotationMarksEnd;
					cm = cm.SuperClass;
				}while (cm != null);
				//Where Clause
				whereClause += " AND "+ q.GetSqlForConditions ();
				if (q.queryClass.SuperClass != null)
				{
					whereClause += " AND " + q.queryClass.StringForInherit;
				}
				//Order Clause
				orderClause += q.orderClause;
				//Group Clause
				groupClause += q.groupClause;
			}

			string selectC="";
			if(this.m_top!=0)
			{
				selectString +=" Top "+this.m_top.ToString()+" ";
			}	

			if (selectClause != "")
			{
				selectC = this.selectString + selectClause.Remove(0,1);
			}
			else
			{
				throw new PlException ("����Sql����",ErrorTypes.PesistentError);
			}
			if(groupClause!="")
			{
				groupClause=" GROUP BY "+groupClause.Remove(0,1);
				orderClause = "";
			}

			//			Console.WriteLine(selectClause);
			//			Console.WriteLine(fromClause);
			//			Console.WriteLine(whereClause);
			//			Console.WriteLine(orderClause);
			//			Console.WriteLine(groupClause);
			if (this.orderClause != "")
			{
				orderClause = " ORDER BY " + orderClause.Remove (0,1);
			}
			this._sqlString = selectC+fromClause+whereClause+orderClause+groupClause; 
			return this._sqlString;
		}

		/// <summary>
		///		ִ�в�ѯ�������ز�ѯ�����
		/// </summary>
		/// <returns>��ѯ���</returns>
		public DataTable Execute()
		{
			PersistenceBroker broker=PersistenceBroker.Instance();
			RelationalDatabase rdb=broker.GetDatabaseCopy(this.DatabaseName);
			IDbCommand cmd = rdb.GetCommand();
			cmd.CommandText=this.BuildForQuery(cmd);
			string cmdText=cmd.CommandText;
			if(rdb.Vendor==DatabaseVendor.Oracle)
			{
				int topInd=cmdText.IndexOf("Top");
				if(topInd!=-1)
				{
					cmdText=cmdText.Substring(0,topInd)+cmdText.Substring(topInd+6);

					//ʹ��ORCALE���rownum�ķ�����װSQL���
					cmdText=PersistenceBroker.AddOracleTopWhere(cmdText,this.Top);	
				}
			}
			cmd.CommandText=cmdText;
			return broker.ExecuteQuery(cmd,this.DatabaseName);
		}

		/// <summary>
		///		ִ�в�ѯ�������ز�ѯ�����ؽ�����ĵ�һ�е�һ�С����Զ�����л���
		/// </summary>
		/// <returns></returns>
		public object ExecuteScalar()
		{
			PersistenceBroker broker = PersistenceBroker.Instance();
			RelationalDatabase rdb=broker.GetDatabaseCopy(this.DatabaseName);
			IDbCommand cmd = rdb.GetCommand ();
			cmd.CommandText=this.BuildForQuery(cmd);		
			DataTable dt = broker.ExecuteQuery(cmd,this.DatabaseName);
			
			if(dt.Rows.Count==0)
			{
				return null;
			}
			else
			{
				return dt.Rows[0][0];
			}
		}

		/// <summary>
		///		�����������������
		/// </summary>
		public void Clear()
		{
			this.selectClause	= "";
			this.fromClause		= "";
			this.orderClause	= "";
			this.m_Querys=null;
		}

		/// <summary>
		///		�����������
		/// </summary>
		/// <param name="attributeName">��attributeName����</param>
		public void OrderBy(string attributeName)
		{
			this.OrderBy(attributeName,true);
		}
		
		/// <summary>
		///		�������
		/// </summary>
		/// <param name="attributeName">��attributeName����</param>
		/// <param name="isAsc">�Ƿ�����</param>
		public void OrderBy(string attributeName ,bool isAsc)
		{
			AttributeMap am=queryClass.GetAttributeMap(attributeName);			
			if(isAsc)
			{
				orderClause+=","+queryClass.GetFullyQualifiedName(am.Column.Name)+" ASC ";
			}
			else
			{
				orderClause+=","+queryClass.GetFullyQualifiedName(am.Column.Name)+" DESC ";
			}
		}
		
		/// <summary>
		/// �Բ�ѯ����������Է���
		/// </summary>
		/// <param name="name">�����������</param>
		public void GroupBy(string name)
		{
			AttributeMap am=queryClass.GetAttributeMap(name);
			this.groupClause+=","+queryClass.GetFullyQualifiedName(am.Column.Name);
		}

		//����Query������ ����string 
		private string GetSqlForConditions ()
		{
			string where = SqlCommander.BuildForConditions (this.m_Conditions);
			if  (where == null)
			{
				return " 1=1 " + this.whereClause ;
			}
			else
			{
				return "( " + where +this.whereClause + " )";
			}
		}

		/*����*/
		/// <summary>
		///		��ѯ��
		/// </summary>
		public string ClassName
		{
			get {return this.queryClass.Name;}
		}
		//����ѯ
		internal Query FatherQuery
		{
			get{return m_FatherQuery;}
			set{m_FatherQuery=value;}
		}
		internal ClassMap QueryClassMap
		{
			get{return this.queryClass;}
		}
		internal ArrayList Conditions
		{
			get{return this.m_Conditions;}
		}
		private ArrayList Querys
		{
			get{return this.m_Querys;}
		}

		/// <summary>
		///		�Ƿ��ų��ظ��У�
		/// </summary>
		public bool IsDistinct
		{
			set 
			{
				if (value)
				{
					this.selectString = "SELECT DISTINCT ";
				}
				else
				{
					this.selectString = "SELECT ";
				}
			}
		}

		/// <summary>
		///		����Sql���
		/// </summary>
		public string SqlString
		{
			get 
			{
				if(this._sqlString==null || this._sqlString.Length==0)
					BuildForQuery( PersistenceBroker.Instance().GetDatabaseCopy(this.DatabaseName).GetCommand());
				return this._sqlString;}
		}

		/// <summary>
		/// ����Դ����
		/// </summary>
		public string DatabaseName
		{
			get
			{
				if(this._databaseName==null)
					this._databaseName=this.queryClass.Database.Name;
				return this._databaseName;
			}
			set
			{
				this._databaseName=value;
			}
				
		}

	}
}
