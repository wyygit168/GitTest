using System;

namespace PersistenceLayer
{
	/// <summary>
	/// DatabaseMap ��ժҪ˵����
	/// </summary>
	class DatabaseMap
	{
		private string m_Name;
		public DatabaseMap(string Name)
		{
			m_Name=Name;
		}
		public string Name
		{
			get{return m_Name;}
		}
	}
}
