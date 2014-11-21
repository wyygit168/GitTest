using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
//using System.Data.Common;

namespace PersistenceLayer
{
	/// <summary>
	///		MsSqlServer ���ݿ�
	/// </summary>
	class MsSqlServer : RelationalDatabase
	{
		private const string GET_IDENTITY = "SELECT @@IDENTITY ";
		private const DatabaseVendor VENDOR_NAME = DatabaseVendor.MsSqlServer;
		
		public MsSqlServer()
		{
			this.Vendor = VENDOR_NAME;
			this.m_QuotationMarksStart = "[";
			this.m_QuotationMarksEnd = "]";
		}

		private MsSqlServer (string name ,string connectionString )
		{
			this.Vendor = VENDOR_NAME;
			this.cnnString = connectionString;
			this.connection = new SqlConnection (connectionString);
			this.Name = name;
		}

		public override int InsertRecord (IDbCommand cmd ,out object identity)
		{
			int result = 0;
			cmd.Transaction = transaction;
			cmd.Connection = connection;
			result = cmd.ExecuteNonQuery();
	
			cmd.CommandText = GET_IDENTITY;
			identity =cmd.ExecuteScalar();
			
			return result;
		}

		public override RelationalDatabase GetCopy()
		{	
			return new MsSqlServer (this.Name,this.cnnString);
		}


		//����һ��DataTable
		public override DataTable AsDataTable(IDbCommand cmd)
		{
			cmd.Connection=this.connection;
			cmd.Transaction = this.transaction;
			
			SqlDataAdapter adapter = new SqlDataAdapter ((SqlCommand)cmd);

			DataTable dt=new DataTable();
			adapter.Fill(dt);
			return dt;
		}

        /// <summary>
        /// ����һ��DataSet
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public override DataSet AsDataSet(IDbCommand cmd)
        {
            cmd.Connection = this.connection;
            cmd.Transaction = this.transaction;
            SqlDataAdapter adapter = new SqlDataAdapter((SqlCommand)cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

		/// <summary>
		/// ��ȡǰN����¼(������AsDataTable�ķ���)
		/// </summary>
		/// <param name="cmd">Command</param>
		/// <param name="top">ǰN��</param>
		/// <returns></returns>
		public override DataTable AsDataTable(IDbCommand cmd,int top)
		{
			cmd.Connection=this.connection;
			cmd.Transaction = this.transaction;
			
			string cmdText=cmd.CommandText;
			if(cmdText.StartsWith("SELECT"))
			{
				cmdText="SELECT TOP "+ top.ToString() +cmdText.Substring(6);
			}

			cmd.CommandText=cmdText;
						
			SqlDataAdapter adapter = new SqlDataAdapter ((SqlCommand)cmd);

			DataTable dt=new DataTable();
			adapter.Fill(dt);
			return dt;
			
		}

		//����һ��SqlDataAdpter
		public override IDataAdapter GetAdapter(IDbCommand cmd)
		{
			SqlDataAdapter adapter = new SqlDataAdapter ();
			adapter.SelectCommand= (SqlCommand)cmd;
			cmd.Connection=connection;
			return adapter;
		}
		
		public override DataRow GetDataRow(IDbCommand cmd)
		{
			cmd.Connection=this.connection;				//�������
			DataRow r ;

			SqlDataAdapter adapter=new SqlDataAdapter();
			adapter.SelectCommand= (SqlCommand) cmd;
			DataTable dt=new DataTable();
			adapter.Fill(dt);
			
			if (dt.Rows.Count>0)
			{
				r = dt.Rows[0];
			}
			else
			{
				r = null;
			}
			return r;
		}

		public override void Initialize(string connectionString)
		{
			cnnString = connectionString.Replace("Provider=SQLOLEDB.1;","");;
			
			try
			{
				//�������
				SqlConnection cnn=new SqlConnection( cnnString);
				this.connection = cnn;
				this.connection.Open();
			}
			catch(SqlException e)
			{
				if(e.Number==17)
                    throw new PlException("���ݿⲻ���ڣ��ο���" + e.Message ,ErrorTypes.DatabaseConnectionError);
				else
					throw new PlException("�������ݿ�ʧ�ܣ��ο���" + e.Message ,ErrorTypes.DatabaseError);
			}
			finally
			{
				this.connection.Close();
			}
		}

		//���ز������ַ�����ʽ
		public override string GetStringParameter (string name,int i)
		{
			return "@" + name;
		}
		
		public override SqlValueTypes SqlValueType (DbType type)
		{
			if (type == DbType.Boolean)
			{
				return SqlValueTypes.BoolToInterger;
			}
			else
			{
				return SqlValueTypes.PrototypeString;
			}
		}

		//������
		public override ErrorTypes ErrorHandler (Exception e,out string message) 
		{
			message = "";
			if (e is SqlException)
			{
				SqlException sqlErr = (SqlException)e;
				int j = 0;
				for (j = 0;j < sqlErr.Errors.Count ;j++)
				{
					if (sqlErr.Errors[j].Number != 3621) break;
				}
				switch (sqlErr.Errors[j].Number)
				{
					case 2627:
						message = "�����ظ���";
						return ErrorTypes.NotUnique;
					case 8152:
						return ErrorTypes.DataTooLong;
					case 515:
						message = "�ο���" + sqlErr.Message;
						return ErrorTypes.NotAllowDataNull;
					case 0:
						return ErrorTypes.DataTypeNotMatch;
					case 544:
						message = "�ο���" + sqlErr.Message;
						return ErrorTypes.AutoValueOn;
					case 547:
						message = "�ο���" + sqlErr.Message;
						return ErrorTypes.RestrictError;
					case 8178:
						message = "�ο���" + sqlErr.Message;
						return ErrorTypes.RequireAttribute;
				}
				message = "���ݿ�����쳣:";
				for(int i =0; i <sqlErr.Errors.Count;i++)
				{
					message += "Index #" + i + "\n" +
						"Message: " + sqlErr.Message + "\n" +
						"Native: " + sqlErr.Errors[i].Number.ToString() + "\n" +
						"Source: " + sqlErr.Errors[i].Source + "\n" ;
				}
				return ErrorTypes.DatabaseUnknwnError;
			}
			else
			{
				message = "";
				return ErrorTypes.Unknown;
			}
		}
	}
}
