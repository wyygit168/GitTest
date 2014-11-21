using System;
using System.Collections;
using System.Data;


namespace PersistenceLayer
{
	/// <summary>
	///		RelationalDatabase 
	/// </summary>
	abstract class  RelationalDatabase
	{
		private string m_Name;								//���ݿ�����
		
		protected string m_QuotationMarksStart = "\"";
		protected string m_QuotationMarksEnd = "\"";
		protected DatabaseVendor m_vendor = DatabaseVendor.MsSqlServer;				//���ݿ�ƽ̨

		protected IDbConnection connection=null;			//���ݿ�����
		protected IDbTransaction transaction=null;		//���ݿ�����
		protected bool isInTransaction=false;				//�Ƿ���������	
		protected string cnnString="";

	
		//Constructor
		public RelationalDatabase()
		{

		}

				
		public RelationalDatabase(string name)
		{
			m_Name=name;
		}
		
		public IDbCommand GetCommand ()
		{
			return this.connection.CreateCommand ();
		}


		//�����ݿ�
		public void Open()
		{
			if (connection.State==ConnectionState.Closed) 
			{
				connection.Open();
			}
		}
		
		//�ر����ݿ�
		public void Close()
		{
			if (this.connection.State==ConnectionState.Open)
				connection.Close();
			this.isInTransaction=false;
		}
		
		//����һ������
		public void BeginTransaction()
		{
			if ((connection==null)||(connection.State==ConnectionState.Closed))
			{
				throw new PlException("���ݿ�δ�򿪻�δ��ʼ����");
			}
			else
			{
				transaction=connection.BeginTransaction();
				isInTransaction=true;
			}
		}

		//�ύһ������
		public void CommitTransaction()
		{
			if (transaction!=null)
			{
				transaction.Commit();
				isInTransaction=false;
				//transaction=null;
			}
			else
			{
				throw new PlException("�޿�������");
			}
		}
		//�ع�һ������
		public void RollbackTransaction()
		{
			if (transaction!=null)
			{
				transaction.Rollback();
				isInTransaction=false;
				transaction=null;
			}
			else
			{
				throw new PlException("�޿�������");
			}
		}

		//ִ��һ������
		public int DoCommand(IDbCommand cmd)
		{
			int result=0;
			if(isInTransaction) cmd.Transaction=transaction;
			cmd.Connection=connection;
			result = cmd.ExecuteNonQuery();
			return result;
		}

		/// <summary>
		/// ִ��һ��SQL��� 
		/// add by tintown at 2004-09-06
		/// </summary>
		/// <param name="sqlstring">���</param>
		/// <returns>Ӱ������</returns>
		public int DoSql(string sqlstring)
		{
			int result=0;
			IDbCommand cmd=GetCommand();
			if(isInTransaction) cmd.Transaction=transaction;
			cmd.Connection=connection;
			cmd.CommandText=sqlstring;
			result = cmd.ExecuteNonQuery();
			return result;
		}

		public IDataReader GetDataReader(IDbCommand cmd)
		{
			cmd.Connection = this.connection;
			cmd.Transaction = this.transaction;
			IDataReader reader = cmd.ExecuteReader();
			return reader;
		}

		//��������ֵ�õ���ȷ��Sqlֵ
		public string GetSqlValue(object obj)
		{
			string type = obj.GetType().ToString();
			type = type.Substring (type.LastIndexOf('.')+1,type.Length);
			
			switch(type)
			{
				case "Int16":
					return obj.ToString();
				case "Int32":
					return obj.ToString();
				case "Int64":
					return obj.ToString();
				case "Single":
					return obj.ToString();
				case "String":
					return "'" + obj.ToString() + "'";
				case "Date":
					return "'" +obj.ToString() + "'";
				case "Guid":
					return "'" + obj.ToString() + "'";
				default:
					throw new PlException("Ŀǰ��֧�ֵ����ݿ����ͣ�");
			}
		}
		public string GetStringAnd()
		{
			return "AND";
		}
		public string GetStringAscend()
		{
			return "ASC";
		}
		public string GetStringBetween()
		{
			return "BETWEEN";
		}
		public string GetStringDelete()
		{
			return "DELETE";
		}
		public string GetStringDescend()
		{
			return "DESC";
		}

		public string GetStringEuqalTo()
		{
			return "=";
		}
		public string GetStringForUpdate()
		{
			return "FOR UPDATE";
		}
		public string GetStringFrom()
		{
			return "FROM";
		}
		public string GetStringHaving()
		{
			return "HAVING";
		}
		public string GetStringIn()
		{
			return "IN";
		}
		public string GetStringInsertInto()
		{
			return "INSERT INTO";
		}
		public string GetStringIs()
		{
			return "IS";
		}
		public string GetStringLike()
		{
			return "LIKE";
		}
		public string GetStringNot()
		{
			return "NOT";
		}
		public string GetStringOr()
		{
			return "OR";
		}
		public string GetStringOrderBy()
		{
			return "ORDER BY";
		}
		public string GetStringSelect()
		{
			return "SELECT";
		}
		public string GetStringSet()
		{
			return "SET";
		}
		public string GetStringUpdate()
		{
			return "UPDATE";
		}
		public string GetStringValues()
		{
			return "VALUES";
		}
		public string GetStringWhere()
		{
			return "WHERE";
		}
		public string GetLeftJoin()
		{
			return "Left Join";
		}

		/// <summary>
		/// �����������ɴ��м����������
		/// ��Password ����Ϊ[Password]����"Password"
		/// </summary>
		/// <param name="columnName"></param>
		/// <returns></returns>
		public string GetQuotationColumn(string columnName)
		{
			return QuotationMarksStart + columnName +QuotationMarksEnd ;
		}


		/*���󷽷�*/
		//����һ��RelationalDatabase 
		public abstract RelationalDatabase GetCopy();

		//������
		public abstract ErrorTypes ErrorHandler (Exception e,out string message) ;

		//ִ�в���һ����¼ �������� �Զ����ɱ�ʶ����
		public abstract int InsertRecord (IDbCommand cmd , out object identity);

		//���ݿ��ʼ��
		public abstract void Initialize(string connectionString);

		//�õ��������ַ�����ʽ
		public abstract string GetStringParameter (string name,int i);
		
		//����һ��IDataAdpter 
		public abstract IDataAdapter GetAdapter(IDbCommand cmd);

		//����һ��DataTable
		public abstract DataTable AsDataTable(IDbCommand cmd);

		//����ǰN����¼DataTable
		public abstract DataTable AsDataTable(IDbCommand cmd,int top);

        //����һ��DataTable
        public abstract DataSet AsDataSet(IDbCommand cmd);

		//����һ��DataRow
		public abstract DataRow GetDataRow(IDbCommand cmd);
		
		public abstract SqlValueTypes SqlValueType (DbType type);

		#region /*����*/

		public string ConnectionString
		{
			get{return this.cnnString;}
		}
		//���ݿ���
		public string Name
		{
			get{return m_Name;}
			set{m_Name=value;}
		}
	
		public bool IsInTransaction
		{
			get{return this.isInTransaction;}
		}

		//���ݿ�ƽ̨��
		public DatabaseVendor Vendor
		{
			get {return this.m_vendor;}
			set {this.m_vendor = value;}
		}
		
		public string QuotationMarksStart
		{
			get{return this.m_QuotationMarksStart;}
			set{this.m_QuotationMarksStart = value;}
		}
		public string QuotationMarksEnd
		{
			get {return this.m_QuotationMarksEnd;}
			set {this.m_QuotationMarksEnd = value;}
		}
		
		#endregion

	}
}
