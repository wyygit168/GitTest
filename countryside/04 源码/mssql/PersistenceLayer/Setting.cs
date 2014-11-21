using System;
using System.Collections;

namespace PersistenceLayer
{
	/// <summary>
	///		�����װ�����á��õ�xml�ļ�·�����Լ�ȡ�����ݿ������ַ����Ĺ���
	///		����ֱ������������ʵ����ֻ��ͨ����̬����Instance()�õ���
	/// </summary>
	public class Setting
	{
		private static Setting _instance=null;
		private string m_DatabaseMapFile="*";
		private Hashtable m_ConnectionStrings ;

		

		/// <summary>
		///		����һ��Setting���ʵ��
		/// </summary>
		protected Setting()
		{
			this.m_ConnectionStrings = new Hashtable ();
		}

		/// <summary>
		///		�����ʵ��ֻ��ͬ��������ȡ��
		/// </summary>
		/// <returns>����һ��Settingʵ��</returns>
		public static Setting Instance()
		{
			if(Setting._instance==null)
			{
				Setting._instance=new Setting();
			}
			return Setting._instance;
		}

		/// <summary>
		///		�õ�һ��ָ�����ݿ�������ִ� 
		/// </summary>
		/// <param name="databaseName">���ݿ�ӳ����</param>
		/// <returns>���������ַ���</returns>
		public string GetConnectionString(string databaseName)
		{
			return this.m_ConnectionStrings [databaseName].ToString ();
		}
		
		internal void SetConnectionString(string databaseName,string connectionString)
		{
			this.m_ConnectionStrings.Add (databaseName,connectionString);
		}
		
		/// <summary>
		///		������ʼ��
		/// </summary>
		public void Initialize()
		{
			if(this.m_DatabaseMapFile=="*")
			{
				throw new PlException("��������xml�ļ���λ��!",ErrorTypes.PesistentError);
			}
			else
			{
				PersistenceBroker.Instance ();
			}
		}

		/// <summary>
		/// ׷������Դ���˷����ṩ����׷������Դ�Ŀ�����
		/// �ڶ����׵�����£�һ������Ҫ��̬׷������Դ��
		/// �������Դ�����ظ�������Զ�����ԭ���ӣ��������Դ���Ʋ�ͬ������Զ�׷�ӽ�ȥ��
		/// 
		/// </summary>
		/// <param name="name">����Դ��</param>
		/// <param name="databaseType">����</param>
		/// <param name="connectionString">�����ַ���</param>
		public void AppendDatabase(string name,DatabaseType databaseType,string connectionString)
		{
			string thisNameSpace = this.ToString ().Substring (0,this.ToString ().LastIndexOf('.')+1);

			PersistenceBroker.Instance().AppendDatabase(name,thisNameSpace+databaseType.ToString(),connectionString);
		}

		/// <summary>
		/// �ֶ�����ClassMap�ļ���
		/// </summary>
		/// <param name="classMapPath">ClassMap��ַ</param>
		public void LoadClassMap(string classMapPath)
		{
			PersistenceBroker.Instance().LoadClassMap(classMapPath);
		}

		/// <summary>
		/// ׷������Դ���˷����ṩ����׷������Դ�Ŀ�����
		/// �ڶ����׵�����£�һ������Ҫ��̬׷������Դ��
		/// �������Դ�����ظ�������Զ�����ԭ���ӣ��������Դ���Ʋ�ͬ������Զ�׷�ӽ�ȥ��
		/// ͬʱ�����ClassMap��Ϣ��
		/// </summary>
		/// <param name="name">����Դ����</param>
		/// <param name="databaseType">����Դ����</param>
		/// <param name="connectionString">�����ַ���</param>
		/// <param name="ClassMapPath">ClassMap��ַ</param>
		public void AppendDatabase(string name,DatabaseType databaseType,string connectionString,string ClassMapPath)
		{
			string thisNameSpace = this.ToString ().Substring (0,this.ToString ().LastIndexOf('.')+1);

			PersistenceBroker.Instance().AppendDatabase(name,thisNameSpace+databaseType.ToString(),connectionString,ClassMapPath);
		}

		/*����*/
		/// <summary>
		///		���á��������ݿ�ӳ���ļ�
		/// </summary>
		public string DatabaseMapFile
		{
			get{return this.m_DatabaseMapFile;}
			set{
				this.m_DatabaseMapFile=value;
				PersistenceBroker.Instance();
			}
		}

		/// <summary>
		/// ��ȡ����Դ�����ݿ��ṩ��
		/// </summary>
		/// <param name="dbName">����Դ����</param>
		/// <returns></returns>
		public DatabaseVendor GetDatabaseVendor(string dbName)
		{
			return PersistenceBroker.Instance().GetDatabase(dbName).Vendor;
		}


		
	}

	/// <summary>
	/// ���ݿ�����
	/// </summary>
	public enum DatabaseType
	{
		/// <summary>
		/// SQL���ݿ�
		/// </summary>
		 MsSqlServer,
		/// <summary>
		/// Access���ݿ�
		/// </summary>
		MsAccess,
		/// <summary>
		/// Oracle���ݿ�
		/// </summary>
		Oracle,

		/// <summary>
		/// Odbc���ݿ�
		/// </summary>
		Odbc,

		/// <summary>
		/// ODP.NET����Oracle
		/// </summary>
		ODP

	
    }

	/// <summary>
	/// ���ݿ��ṩ������
	/// </summary>
	public enum DatabaseVendor
	{
		/// <summary>
		/// Microsoft SQL Server ���ݿ�
		/// </summary>
		MsSqlServer,
		/// <summary>
		/// Microsoft Access ���ݿ�
		/// </summary>
		MsAccess,
		/// <summary>
		/// Oracle ���ݿ�
		/// </summary>
		Oracle,
		/// <summary>
		/// ODBC���ӷ�ʽ
		/// </summary>
		Odbc,
		/// <summary>
		/// Informix���ݿ�
		/// </summary>
		Informix,
		/// <summary>
		/// MySql ���ݿ⣨����.NET���ӣ�
		/// </summary>
		MySql
	}
	
}
