using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	///		DeleteCriteria �������Condition����ָ����������ɾ��һ������ʵ�����
	/// </summary>
	public class DeleteCriteria : PersistentCriteria
	{
		
		private string _sqlString;
		private ClassMap _classMap ;
		private ArrayList _conditions = new ArrayList ();
		private PersistenceBroker _broker = PersistenceBroker.Instance ();
		
				
		
	
		

	
		
		
		/// <summary>
		///		����һ��DeleteCriteria
		/// </summary>
		/// <param name="classType">��Ҫ����ʵ������Tpye����</param>
		public DeleteCriteria(Type classType)
		{
			this.ForClass=classType;
			this.CriteriaType = CriteriaTypes.Delete;
			this._classMap = _broker.GetClassMap (classType.Name);
			this._databaseName=this._classMap.Database.Name ;
			this._IsSaveInMemory=this._classMap.IsSaveToMemory;
			
		}

		/// <summary>
		/// ����һ��DeleteCriteria
		/// </summary>
		/// <param name="classType">ʵ������</param>
		/// <param name="databaseName">����Դ����</param>
		public DeleteCriteria(Type classType,string databaseName)
		{
			this.ForClass=classType;
			this.CriteriaType = CriteriaTypes.Delete;
			this._classMap = _broker.GetClassMap (classType.Name);
			this._databaseName=databaseName;
			this._IsSaveInMemory=this._classMap.IsSaveToMemory;
			
			
		}
		
		/// <summary>
		///		ִ��ɾ������
		/// </summary>
		/// <returns>��Ӱ�������</returns>
		public int Perform()
		{
			//this.m_Criteria.Perform();
			//PersistenceBroker broker=PersistenceBroker.Instance();
			//return broker.ProcessDeleteCriteria(this);
			if(this._databaseName==null)
				this._databaseName=this._classMap.Database.Name;

			return _broker.ProcessCriteria(this);
			
//			IDbCommand  cmd = this._broker.GetCommand (_databaseName);
//			this.BuildStringForDelete();
//
//			cmd.CommandText=this._sqlString;
//			int infect=_broker.Execute(_databaseName,cmd);
//			if(infect>0 && this._IsSaveInMemory==true)
//			{
//					
//
//			}
//			return infect;


			//return _broker.ProcessCriteria (this.m_Criteria);
		}

		/// <summary>
		///		�õ�һ������������� 
		/// </summary>
		/// <returns>Condition���󣬿�����Condition����ָ����������</returns>
		public Condition GetNewCondition()
		{
			//return this.m_Retrieve.GetNewCondition();

			Condition c = new Condition (this._classMap);
			this._conditions.Add (c);
			return c;
		}

		internal void BuildStringForDelete ()
		{
			this._sqlString = _classMap.DeleteFromClause;

			string where = SqlCommander.BuildForConditions (this._conditions);
			if (where != null)
				_sqlString += " WHERE " + where ;
			
		}

	
		
		
	
		/// <summary>
		/// 
		/// </summary>
		public string SqlString
		{
			get
			{
				if(this._sqlString==null || this._sqlString.Length==0)
					this.BuildStringForDelete();
				return this._sqlString;
			}
		}


		/// <summary>
		/// 
		/// </summary>
		public string classMapName
		{
			get
			{
				return this._classMap.Name;
			}
		}

	

	
	}
}
