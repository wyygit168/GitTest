using System;
using System.Collections;

namespace PersistenceLayer
{
	/// <summary>
	///	UpdateCriteria ���±�׼
	///	�������һ��ʵ���ϵ�ָ��������ָ�������ֶβ���
	///	����Update table set field=value where ...
	///	������������ģʽ
	/// </summary>
	public class UpdateCriteria : PersistentCriteria
	{
		
		private string _sqlString;
		private ClassMap _classMap ;
		private ArrayList _conditions = new ArrayList ();
		private PersistenceBroker _broker = PersistenceBroker.Instance ();
		
		

		private Hashtable m_ForUpdateCollection=new Hashtable();
		
		/// <summary>
		/// ���캯��
		/// </summary>
		/// <param name="classType">����</param>
		public UpdateCriteria(Type classType)
		{
			this.ForClass=classType;
			this.CriteriaType = CriteriaTypes.Update;
			this._classMap=_broker.GetClassMap(classType.Name);
			this._databaseName=this._classMap.Database.Name ;
			this._IsSaveInMemory=this._classMap.IsSaveToMemory;
						
		}

		/// <summary>
		/// ���캯��
		/// </summary>
		/// <param name="classType">����</param>
		/// <param name="databaseName">����Դ����</param>
		public UpdateCriteria(Type classType,string databaseName)
		{
			this.ForClass=classType;
			this.CriteriaType = CriteriaTypes.Update;
			this._classMap=_broker.GetClassMap(classType.Name);
			this._databaseName=databaseName;
			this._IsSaveInMemory=this._classMap.IsSaveToMemory;
						
		}
		
		/// <summary>
		///		ִ�������²���
		/// </summary>
		/// <returns>��Ӱ�������</returns>
		public int Perform()
		{
			//����Ҫ���µ�ֵ���뼯��
//			for (int i =1;i< this.m_ForUpdateCollection.Count ;i=i+2)
//			{
//				this.m_ForUpdateCollection[i] = templateObjectForUpdate.GetAttributeValue (
//					this.m_ForUpdateCollection[i-1].ToString());
//			}
//		
//			PersistenceBroker broker = PersistenceBroker.Instance();
//			return broker.ProcessCriteria (this);
			if(this._databaseName==null)
				this._databaseName=this._classMap.Database.Name;
			return _broker.ProcessCriteria(this);
			 
		}

		/// <summary>
		///		�õ�һ�������������
		/// </summary>
		/// <returns>Conditionʵ��</returns>
		public Condition GetNewCondition()
		{
			//return this.m_Retrieve.GetNewCondition();

			Condition c = new Condition (this._classMap);
			this._conditions.Add (c);
			return c;
		}

		/// <summary>
		///	����һ����Ҫ��������
		///	�ɴ˷��������Ҫ���µ��ֶ���ֵ
		/// </summary>
		public void AddAttributeForUpdate (string attributeName,object attributeValue)
		{
			
			this.m_ForUpdateCollection.Add(attributeName,attributeValue);
//			this.m_ForUpdateCollection.Add (attributeName);
//			this.m_ForUpdateCollection.Add (templateObjectForUpdate.GetAttributeValue (attributeName));
		}


		internal void BuildStringForUpdate()
		{
			string where = SqlCommander.BuildForConditions (this._conditions);

			this._sqlString="UPDATE ";
			this._sqlString +=this.classMap.RelationalDatabase.QuotationMarksStart+this.classMap.Table.Name+this.classMap.RelationalDatabase.QuotationMarksEnd;
			this._sqlString +=" SET ";
			int i=0;
			foreach(object key in this.m_ForUpdateCollection.Keys)
			{
				this._sqlString +=this._classMap.RelationalDatabase.QuotationMarksStart+this._classMap.GetAttributeMap(key.ToString()).Column.Name+this._classMap.RelationalDatabase.QuotationMarksEnd+"=";
				this._sqlString +=this._classMap.RelationalDatabase.GetStringParameter(key.ToString(),i);
				this._sqlString +=",";
				i++;
			}

//			//tintown added at 2005-3-22 ��Ӷ�timestamp�ĸ���
			//�����ڸ��±�׼ʱ������timestamp�жϣ����Բ���Ҫ����timestampֵ��Ҫ��Ȼ���ᵼ�������е�ͬһ����²��ɹ���
//			if(_classMap.TimestampAttribute!=null)
//			{
//				ColumnMap cm=_classMap.TimestampAttribute.Column ;
//				this._sqlString+=cm.Name+"=";
//				this._sqlString+=this._classMap.RelationalDatabase.GetStringParameter("Update"+cm.Name,i);
//				this._sqlString+=",";
//			}


			char[] chars=new char[]{','};
			this._sqlString=this._sqlString.TrimEnd(chars);

			
			
			if (where != null)
				_sqlString += " WHERE " + where ;

			
		}

	

		internal Hashtable ForUpdateCollection 
		{
			get {return this.m_ForUpdateCollection;}
		}

		/// <summary>
		/// 
		/// </summary>
		public string SqlString
		{
			get
			{
				if(this._sqlString==null || this._sqlString.Length==0)
					BuildStringForUpdate();
				return this._sqlString;
			}
		}


		/// <summary>
		/// 
		/// </summary>
		internal ClassMap classMap
		{
			get
			{
				return this._classMap;
			}
		}
		
	}
}
