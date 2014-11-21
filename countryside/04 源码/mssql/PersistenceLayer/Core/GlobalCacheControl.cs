using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// DirtyControl ��ժҪ˵����
	/// �����ݿ�����࣬���ڿ���ʵ���������
	/// </summary>
	internal class GlobalCacheControl : Hashtable
	{
		private static GlobalCacheControl control=null;
		private Hashtable dirtyCodes=new Hashtable();
		private GlobalCacheControl()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public static GlobalCacheControl Instance()
		{
			if(control==null)
				control=new GlobalCacheControl();
			return control;
			
		}

		public void Add(string key,DataTable dt)
		{
			if(base.Contains(key))
				base[key]=dt;
			else
                base.Add(key,dt);
				
		}

		public void RemoveIt(string key)
		{
			if(base.Contains(key))
				base.Remove(key);
		}

		public DataTable GetEntityContainer(string key)
		{
			return (DataTable)base[key];
		}


	}
}
