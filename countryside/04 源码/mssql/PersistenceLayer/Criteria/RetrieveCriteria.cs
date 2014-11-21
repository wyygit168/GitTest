using System;
using System.Collections;
using System.Data;
using System.Text;

namespace PersistenceLayer
{
	/// <summary>
	///		RetrieveCriteria 该类封装了一次获取一个或多个EntityObject对象的行为。
	/// </summary>
	public class RetrieveCriteria
	{
		private bool m_IsIncludeAssociation = false;
		private string forClassName ;
		private ClassMap _classMap ;
		private PersistenceBroker _broker = PersistenceBroker.Instance ();
		private ArrayList _conditions = new ArrayList ();
		private ArrayList _orderList = null;
		private string _sqlString;
		private Type _forClass ;
		private int m_top=0;
		private string _databaseName=null;
		private string selectClause="";

		private string sTemp ;
		private string endQuostationMarks;

		private string selectString = "SELECT ";

		//在事务中处理RetrieveCriteria时使用(tintown)
		private RelationalDatabase m_rdb=null;

		internal RelationalDatabase Rdb
		{
			set
			{
				m_rdb=value;
			}
			get
			{
				return m_rdb;
			}
		}
		
		
		/// <summary>
		/// 用于控制此返回是否要保存在内存
		/// false:不保存在内存中。则每次都从数据库读取，此为默认值
		/// true:保存到内存中，如果内存中存在就直接从内存中读取，对于基础数据建议使用此功能。
		/// 对于操作性数据不推荐，这导致大量内存被占
		/// </summary>
		private bool _IsSaveInMemory=false;

		/// <summary>
		/// 如果要保存到内存的话，将把此值作为唯一的KEY值。
		/// </summary>
		private string _memoryKey="";

		/// <summary>
		///		生成一个RetrieveCriteria实例
		/// </summary>
		/// <param name="classType">EntityObject的Type对象</param>
		public RetrieveCriteria(Type classType)
		{
			this._forClass = classType;
			this.forClassName = EntityObject.GetClassName (classType);
			this._classMap = _broker.GetClassMap (forClassName);
			this._databaseName=this._classMap.Database.Name;
			this._IsSaveInMemory=this._classMap.IsSaveToMemory;
			sTemp = " AS " + _classMap.RelationalDatabase.QuotationMarksStart;
			endQuostationMarks = _classMap.RelationalDatabase.QuotationMarksEnd;
			
			
		}


		/// <summary>
		/// add by tintown at 2004-10-23
		/// </summary>
		/// <param name="classType"></param>
		/// <param name="databaseName"></param>
		public RetrieveCriteria (Type classType,string databaseName)
		{
			this._forClass = classType;
			this.forClassName = EntityObject.GetClassName (classType);
			this._classMap = _broker.GetClassMap (forClassName);
			this._databaseName=databaseName;
			this._IsSaveInMemory=this._classMap.IsSaveToMemory;
			sTemp = " AS " + _classMap.RelationalDatabase.QuotationMarksStart;
			endQuostationMarks = _classMap.RelationalDatabase.QuotationMarksEnd;
		}


		/// <summary>
		///增加一个属性，并以属性名作为返回DataTable的列名
		/// </summary>
		/// <param name="attributeName"></param>
		public void AddSelect(string attributeName)
		{
			AttributeMap am=this._classMap.GetAttributeMap(attributeName,true);
			selectClause+=","+_classMap.GetFullyQualifiedName(am.Column.Name) + sTemp + am.Name + endQuostationMarks;
		}

		/// <summary>
		///		增加一个属性 并以asName作为返回DataTable的列名 
		/// </summary>
		public void AddSelect(string attributeName,string asName)
		{
			AttributeMap am=this._classMap.GetAttributeMap(attributeName,true);		
			selectClause+=","+_classMap.GetFullyQualifiedName(am.Column.Name) + sTemp + asName + endQuostationMarks;
		}

		/// <summary>
		/// 定义选择所有的属性
		/// </summary>
		/// <param name="all"></param>
		public void AddSelect(AttributeType all)
		{
			if(all==AttributeType.All)
			{
				AttributeMap am;
				for(int i=0;i<this._classMap.Attributes.Count;i++)
				{
					am=this._classMap.GetAttributeMap(i);
					selectClause+=","+_classMap.GetFullyQualifiedName(am.Column.Name) + sTemp + am.Name + endQuostationMarks;
				}
			}
		}

		private string GetSelectClause()
		{
			string tempSelect="";
			if (selectClause != "")
			{
				tempSelect = this.selectString + selectClause.Remove(0,1);
				tempSelect +=" FROM " + this._classMap.RelationalDatabase.QuotationMarksStart+this._classMap.Table.Name+this._classMap.RelationalDatabase.QuotationMarksEnd;
			}
			else
			{
				tempSelect=_classMap.SelectFromClause;
			}
			return tempSelect;
		}

		internal void BuildStringForRetrieve ()
		{
				this._sqlString = SqlCommander.BuildForConditions ( _conditions);

				//如果不能使用Where从句
				if (_classMap.SuperClass == null && _sqlString == null)
				{
					_sqlString = GetSelectClause();
				}
				else
				{
					//如果未指定过滤条件，且_classMap.SuperClass !=null
					if (_sqlString == null)
					{
						_sqlString = GetSelectClause() + " WHERE " + _classMap.StringForInherit;
					}
						//如果指定了过滤条件(_sqlString!= null)
					else
					{
						_sqlString = GetSelectClause() + " WHERE " + _sqlString ;
						//且有父类
						if (_classMap.SuperClass != null)
						{
							_sqlString += " AND " + _classMap.StringForInherit;
						}
					}
				}
				//Order by
				if (this._orderList != null)
				{
					this._sqlString += SelectCommander.GetOrderSql (_orderList,_classMap);
				}
			
		}

		/// <summary>
		///		返回一个ObjectCursor对象 
		/// </summary>
		/// <returns>ObjectCursor</returns>
		public ObjectCursor AsCursor()
		{
			//tintown add at 2004-10-23
//			if(this._databaseName==null)
//				this._databaseName=this._classMap.Database.Name;
//			IDbCommand  cmd = this._broker.GetCommand (_databaseName);
//			this.BuildStringForRetrieve ();
//			cmd.CommandText = this._sqlString;
//			DataTable dt = _broker.ExecuteQuery (cmd,_databaseName);
			DataTable dt=AsDataTable();
			//DataSet ds = new DataSet();
			//ds.Tables.Add (dt);
			ObjectCursor aCursor= new ObjectCursor(this.ForClass,dt,this.m_IsIncludeAssociation);			
			return aCursor;
		}

		/// <summary>
		/// tintown add at 2004-10-24
		/// 此方法主要方便于那些非主键查询，能及时获取唯一对象
		/// 如果查询中存在多个对象，系统则返回第一条记录
		/// </summary>
		/// <returns></returns>
		public EntityObject AsEntity()
		{
			EntityObject eo=null;
			ObjectCursor oc=AsCursor();
			if(oc.HasObject())
			{
				eo=(EntityObject)oc.NextObject();
				
			}

			return eo;
		}

		/// <summary>
		/// 返回实体集
		/// </summary>
		/// <returns></returns>
		public EntityContainer AsEntityContainer()
		{
			EntityContainer ec=new EntityContainer();
			ObjectCursor oc=AsCursor();
			for(int i=0;i<oc.Count;i++)
			{
				ec.Add((EntityObject)oc.NextObject());
			}
			return ec;
			

		}
		
		/// <summary>
		///		根据查询条件返回一个结果集
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable AsDataTable()
		{
			//tintown add at 2004-10-23

			return _broker.ProcessRetrieveCriteria(this);

//			if(this._databaseName==null)
//				this._databaseName=this._classMap.Database.Name;
//			IDbCommand  cmd = this._broker.GetCommand (_databaseName);
//			this.BuildStringForRetrieve ();
//
//			if(this._IsSaveInMemory)
//			{
//				if(GlobalCacheControl.Instance().Contains(this.MemoryKey))
//				{
//					DataTable dt=GlobalCacheControl.Instance().GetEntityContainer(this.MemoryKey);
//					int whereInd=this._sqlString.LastIndexOf("WHERE");
//					int orderInd=this._sqlString.LastIndexOf("ORDER BY");
//					string where="";
//					string order="";
//					if(whereInd!=-1)
//					{
//						where=this._sqlString.Substring(whereInd+5).Replace(this._classMap.Table.Name+".","");
//					}
//					if(orderInd!=-1)
//					{
//						if(where!="")
//                            where=where.Substring(0,where.LastIndexOf("ORDER BY"));
//						order=this._sqlString.Substring(orderInd+9).Replace(this._classMap.Table.Name+".","");
//					}
//					
////					DataView dv=new DataView(dt,where,order,DataViewRowState.None);
////
////					DataTable dt2=dv.Table.Copy();
//
//					DataRow[] drs=dt.Select(where,order);
//					DataTable dt2=dt.Copy();
//					dt2.Rows.Clear();
//					foreach(DataRow row in drs)
//					{
//						
//						DataRow row2=dt2.NewRow();
//						for(int i=0;i<row2.Table.Columns.Count;i++)
//							row2[i]=row[i];
//
//						dt2.Rows.Add(row2);
//
//
//					}
//					return dt2;
//				}
//				else
//				{
//					//添加到内存中begin
//
//					int x=this._sqlString.LastIndexOf("WHERE");
//					cmd.CommandText=this._sqlString;
//					if(x!=-1)
//                        cmd.CommandText = this._sqlString.Substring(0,this._sqlString.LastIndexOf("WHERE"));
//					DataTable dt=_broker.ExecuteQuery(cmd,_databaseName);
//									
//					GlobalCacheControl.Instance().Add(this.MemoryKey,dt);
//
//
//					//添加到内存中end
//
//					//返回Datatable
//					cmd.CommandText=this._sqlString;
//					return _broker.ExecuteQuery(cmd,_databaseName);
//					
//
//				}
//				
//			}
//			else
//			{
//				
//				cmd.CommandText = this._sqlString;
//				if(this.m_top==0)
//					return _broker.ExecuteQuery(cmd,_databaseName);
//				else
//					return _broker.ExecuteQuery(cmd,_databaseName,this.m_top);
//			}
		}
		
		/// <summary>
		///		得到一个新条件类对象
		/// </summary>
		public Condition GetNewCondition()
		{
			Condition c = new Condition (this._classMap);
			this._conditions.Add (c);
			return c;
		}

		/// <summary>
		///		等价于OrderBy(attributeName,true)
		/// </summary>
		public void OrderBy(string attributeName)
		{
			this.OrderBy(attributeName,true);
		}
		/// <summary>
		///		获取的对象排序。
		/// </summary>
		/// <param name="attributeName">排序依据的属性</param>
		/// <param name="isAsc">isAsc=true ,按升序排序，isAsc=false 则按降序排序</param>
		public void OrderBy(string attributeName ,bool isAsc)
		{
			OrderEntry order=new OrderEntry(attributeName,isAsc);
			if (this._orderList == null)
			{
				_orderList = new ArrayList();
			}
			this._orderList.Add (order);
		}
		
		/// <summary>
		///		清除所有已设置的Condition对象
		/// </summary>
		public void Clear()
		{
			this._conditions.Clear ();
		}

		/*属性*/
		/// <summary>
		///		指定的类的Type类型
		/// </summary>
		public Type ForClass
		{
			get
			{
				return this._forClass;
			}
		}
		/// <summary>
		///		是否获取各个关联对象 
		/// </summary>
		internal bool IsIncludeAssociation
		{
			get
			{
				return this.m_IsIncludeAssociation;
			}
			set
			{
				this.m_IsIncludeAssociation = value;
			}
		}
	
		/// <summary>
		///		返回Sql语句
		/// </summary>
		public string SqlString
		{
			get {
				if(this._sqlString==null || this._sqlString.Length==0)
					BuildStringForRetrieve();
				return this._sqlString;}
		}

		/// <summary>
		/// 头N条属性
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
		/// 数据源名称
		/// </summary>
		public string DatabaseName
		{
			set
			{
				this._databaseName=value;
			}
			get
			{
				if(this._databaseName==null)
					this._databaseName=this._classMap.Database.Name;
				return this._databaseName;
			}
		}

		internal bool IsSaveInMemory
		{
			set
			{this._IsSaveInMemory=value;}
			get
			{return this._IsSaveInMemory;}
		}


		/// <summary>
		/// 
		/// </summary>
		internal string MemoryKey
		{
			set
			{this._memoryKey=value;}
			get
			{
				if(this._memoryKey=="")
					this._memoryKey=this.DatabaseName +"_"+this.ForClass.Name;
				return this._memoryKey;
			}
		}
	

		internal ClassMap classMap
		{
			get
			{
				return this._classMap;
			}
		}
	}
}
