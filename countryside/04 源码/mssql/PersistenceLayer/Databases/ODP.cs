using System;
using System.Data;
//using System.Data.Common;
using System.Collections;
using Oracle.DataAccess.Client;

namespace PersistenceLayer
{
	/// <summary>
	/// ODP ��ժҪ˵����
	/// </summary>
	class ODP :RelationalDatabase
	{
		//ʹ�ô�ֵ���ж����ڱȽϵ������ԣ�Oracle�Ļ���������ڽ���to_date()��ת��
		private const DatabaseVendor VENDOR_NAME = DatabaseVendor.Oracle;
		public ODP ()
		{
			this.Vendor = VENDOR_NAME;
		}

		private ODP (string name ,string connectionString )
		{
			this.Vendor = VENDOR_NAME;
			this.cnnString = connectionString;
			this.connection = new OracleConnection(connectionString);
			this.Name = name;
		}

		public override int InsertRecord (IDbCommand cmd ,out object identity)
		{
			throw new PlException ("��֧�����Զ���Ź��ܣ�");
			//return 0;
		}

		public override RelationalDatabase GetCopy()
		{	
			return new ODP (this.Name,this.cnnString);
		}

		//����һ��DataTable
		public override DataTable AsDataTable(IDbCommand cmd)
		{
			cmd.Connection=this.connection;
			cmd.Transaction = this.transaction;
			OracleDataAdapter adapter = new OracleDataAdapter((OracleCommand)cmd);
			
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

			
			//ʹ��ORCALE���rownum�ķ�����װSQL���
			cmd.CommandText=PersistenceBroker.AddOracleTopWhere(cmdText,top);		
			OracleDataAdapter adapter = new OracleDataAdapter((OracleCommand)cmd);
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
            OracleDataAdapter adapter = new OracleDataAdapter((OracleCommand)cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

		//����һ��SqlDataAdpter
		public override IDataAdapter GetAdapter(IDbCommand cmd)
		{
			OracleDataAdapter adapter = new OracleDataAdapter();
			adapter.SelectCommand=(OracleCommand)cmd;
			cmd.Connection=connection;
			return adapter;
		}
		
		//����һ��DataRow
		public override DataRow GetDataRow(IDbCommand cmd)
		{
			cmd.Connection=this.connection;				//�������
			DataRow r ;

			OracleDataAdapter adapter=new OracleDataAdapter();
			adapter.SelectCommand= (OracleCommand) cmd;
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
				OracleConnection cnn=new OracleConnection(cnnString);
				this.connection=cnn;
				this.connection.Open();
			}
			catch(OracleException e)
			{
				throw new PlException("�������ݿ�ʧ�ܣ��ο���" + e.Message ,ErrorTypes.DatabaseError);
			}
			catch(Exception e)
			{
				throw e;
			}
			finally
			{
				this.connection.Close();
			}
		}

		//���ز������ַ�����ʽ
		public override string GetStringParameter (string name,int i)
		{
			return ":"+i.ToString();
			
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
			if (e is OracleException)
			{
				OracleException oleErr = (OracleException) e; 
				for(int i=0; i <oleErr.Errors.Count;i++)
				{
					message += "Index #" + i + "\n" +
						"Message: " + oleErr.Message + "\n" +
						"Number: " + oleErr.Errors[i].Number.ToString() + "\n" +
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
