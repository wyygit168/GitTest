using System;
using System.Data.OleDb;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// ColumnMap ��ժҪ˵����
	/// </summary>
	class ColumnMap
	{

		private string m_Name;
		private ColumnKeyTypes _KeyType;
		private TableMap _TableMap;
		private DbType m_Type;
		private bool m_AutoValue = false;

		//Constructor
		public ColumnMap(string name,TableMap table)
		{
			this.m_Name=name;
			this._TableMap=table;
		}
		public TableMap Table				//��Ӧ��TableMap
		{
			get{return _TableMap;}
		}
//		public string GetFullyQualifiedName()
//		{
//			return(_TableMap.Name +"."+m_Name+"");
//		}
		public string GetFullNameWithNoDot()
		{
			return(_TableMap.Name+m_Name);
		}

		/*����*/
		
		//����
		public string Name					
		{
			get{return m_Name;}
		}
		//��������
		public DbType Type
		{
			get{return this.m_Type;}
			set{this.m_Type=value;}
		}
		//������
		public ColumnKeyTypes KeyType
		{
			get{return _KeyType;}
			set{_KeyType=value;}
		}
		//�Ƿ��Զ�����ֵ
		public bool IsAutoValue
		{
			get{return m_AutoValue;}
			set{m_AutoValue = value;}
		}
	}
}
