using System;
using System.Collections;

namespace PersistenceLayer
{
	/// <summary>
	/// IConfigLoader ��ժҪ˵����
	/// </summary>
	interface IConfigLoader
	{
		//����
		void LoadConfig(string databaseMap);
		//����
		Hashtable DatabaseMaps{get;}
		Hashtable ClassMaps{get;}
		IDictionary DatabasePool{get;}
	}
}
