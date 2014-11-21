using System;

namespace PersistenceLayer
{
	/// <summary>
	/// TableMap ��ժҪ˵����
	/// </summary>
	class TableMap
	{
		private string _name;
		private DatabaseMap _databaseMap;
		private string _timestampColumn;
		private string _timestampParameter;
		

		public int AutoIdentityIndex = -1;
		public int PrimaryKeyIndex = -1;

		//TableMap���캯��
		public TableMap()
		{
				
		}
		public TableMap(string name,DatabaseMap database)
		{
			_name=name;
			_databaseMap=database;
		}
	
		public string Name					//�������������
		{
			get{return _name;}
			set{_name=value;}
		}
		public DatabaseMap Database			//�����������ݿ�ӳ����
		{
			get{return _databaseMap;}
			set{_databaseMap=value;}
		}
		
		public string TimestampColumn
		{
			get{return this._timestampColumn;}
			set{this._timestampColumn = value;}
		}

		public string TimestampParameter
		{
			get { return this._timestampParameter;}
			set {this._timestampParameter = value;}
		}
	
	}
}
