using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// ��׼��һ�����࣬UpdateCriteria��DeleteCriteria���̳��Դ���
	/// </summary>
	public abstract class PersistentCriteria
	{
		private CriteriaTypes m_CriteriaType;
		private Type classType=null;
		/// <summary>
		/// ָ������Դ��
		/// </summary>
		protected string _databaseName=null;
		/// <summary>
		/// �ڴ澵��ʱKeyֵ
		/// </summary>
		protected string _memoryKey="";
		/// <summary>
		/// �Ƿ�Ҫ�ڴ澵��
		/// </summary>
		protected bool _IsSaveInMemory=false;
		

		/// <summary>
		/// ���캯��
		/// </summary>
		public PersistentCriteria()
		{
		}
		

		/// <summary>
		/// ���õ�����
		/// </summary>
		public Type ForClass
		{
			get{return this.classType;}
			set{this.classType=value;}
		}
		
		/// <summary>
		/// ��׼������
		/// </summary>
		internal CriteriaTypes CriteriaType
		{
			get
			{
				return this.m_CriteriaType;
			}
			set
			{
				this.m_CriteriaType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string DatabaseName
		{
			set
			{
				this._databaseName=value;
			}
			get
			{
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

	
	}

		
}