using System;
using System.Data;
//using System.Data.Common;
using System.Data.OleDb;
using System.Collections;

namespace PersistenceLayer
{
	/// <summary>
	/// OtherDataBase ��ժҪ˵����
	/// </summary>
	class Informix :RelationalDatabase
	{
		private const DatabaseVendor VENDOR_NAME = DatabaseVendor.Informix;
		
		public Informix ()
		{
			this.Vendor = VENDOR_NAME;
			m_QuotationMarksStart = "";
			m_QuotationMarksEnd = "";
		}

		private Informix (string name ,string connectionString )
		{
			this.Vendor = VENDOR_NAME;
			this.cnnString = connectionString;
			this.connection = new OleDbConnection (connectionString);
			this.Name = name;
			m_QuotationMarksStart = "";
			m_QuotationMarksEnd = "";
		}

		public override int InsertRecord (IDbCommand cmd ,out object identity)
		{
			throw new PlException ("��֧�����Զ���Ź��ܣ�");
			//return 0;
		}

		public override RelationalDatabase GetCopy()
		{	
			return new Informix (this.Name,this.cnnString);
		}

		//����һ��DataTable
		public override DataTable AsDataTable(IDbCommand cmd)
		{
			cmd.Connection=this.connection;
			cmd.Transaction = this.transaction;
			OleDbDataAdapter adapter = new OleDbDataAdapter((OleDbCommand)cmd);
			
			DataTable dt=new DataTable();
			adapter.Fill(dt);
			return dt;
		}

		/// <summary>
		/// ��ȡǰN����¼(δʵ��Oracle����)
		/// add by tintown at 2004-09-06
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="top"></param>
		/// <returns></returns>
		public override DataTable AsDataTable(IDbCommand cmd,int top)
		{
			cmd.Connection=this.connection;
			cmd.Transaction = this.transaction;
			string cmdText=cmd.CommandText;
			OleDbDataAdapter adapter = new OleDbDataAdapter((OleDbCommand)cmd);
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
            OleDbDataAdapter adapter = new OleDbDataAdapter((OleDbCommand)cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

		//����һ��SqlDataAdpter
		public override IDataAdapter GetAdapter(IDbCommand cmd)
		{
			OleDbDataAdapter adapter = new OleDbDataAdapter();
			adapter.SelectCommand=(OleDbCommand)cmd;
			cmd.Connection=connection;
			return adapter;
		}
		
		//����һ��DataRow
		public override DataRow GetDataRow(IDbCommand cmd)
		{
			cmd.Connection=this.connection;				//�������
			DataRow r ;

			OleDbDataAdapter adapter=new OleDbDataAdapter();
			adapter.SelectCommand= (OleDbCommand) cmd;
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
			cnnString = connectionString;//.Replace("Provider=SQLOLEDB.1;","");;
			try
			{
				//�������
				OleDbConnection cnn=new OleDbConnection( cnnString);
				this.connection=cnn;
				this.connection.Open();
			}
			catch(OleDbException e)
			{
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
			return "?";
			
		}
		public override SqlValueTypes SqlValueType (DbType type)
		{
			if (type == DbType.Boolean)
			{
				return SqlValueTypes.PrototypeString;
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
			if (e is OleDbException)
			{
				OleDbException oleErr = (OleDbException) e; 
				for(int i=0; i <oleErr.Errors.Count;i++)
				{
					message += "Index #" + i + "\n" +
						"Message: " + oleErr.Message + "\n" +
						"Native: " + oleErr.Errors[i].NativeError.ToString() + "\n" +
						"Source: " + oleErr.Errors[i].Source + "\n" ;
				}
				return ErrorTypes.DatabaseUnknwnError;
			}
			else
			{
				return ErrorTypes.Unknown;
			}
		}

	}
}
