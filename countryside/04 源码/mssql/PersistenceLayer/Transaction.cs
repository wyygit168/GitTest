using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace PersistenceLayer
{
	/// <summary>
	///	��������
	///	��������֧�����ֻ��ƣ�һ����ʹ��Add...��Process()��һ�����ύ����
	///	��һ����ʹ��Do..��Commit()��RollBack()��ʵʱ�ύ����
	///	���ֻ��Ʋ��ܻ��ʹ�ã���Ҫ��ʹ��Process()��ʽ �ģ���ôֻ��ʹ��Add�ķ���
	///	�����ʹ��Commit()�Ļ�����ֻ����Do�����������ʹ��ʱ��Ҫע�⡣
	///	�����ֻ��Ƹ������ƣ���֧�ֶ��칹���ݿ���ϡ�
	/// </summary>
	public class Transaction
	{
		private IList tasks=null;
		private IList actions=null;
		/// <summary>
		/// tintown added at 2005-3-23
		/// �����ж��Ƿ�ǿ��Commit��Ĭ��Ϊfalse
		/// flase:��ǿ��Commit����ָ��ʵ��Save()����ʵ��Delete()ʱ������false�ͻع���������,�����ڲ����Դ���
		/// true:ǿ��Commit,��ָ����ʵ��Save()��Delete()���ص�false״̬����Ϊ��ʱ����ҵ���ϱ����������ġ�
		/// </summary>
		private bool m_IsForceCommit=false;

		PersistenceBroker broker=PersistenceBroker.Instance();
		private Hashtable rdbs=new Hashtable();

		//
		/// <summary>
		///		Constructor
		/// </summary>
		public Transaction()
		{
			this.tasks=new ArrayList();
			this.actions=new ArrayList();
			
		}

		/// <summary>
		///		������������һ��Save���� 
		/// </summary>
		/// <param name="obj">��Ҫִ��Save��ʵ�����</param>
		public void AddSaveObject(EntityObject obj)
		{
			this.tasks.Add(obj);
			if (obj.IsPersistent)
			{
				this.actions.Add(ActionTypes.UpdateCommand);
			}
			else
			{
				this.actions.Add(ActionTypes.InsertCommand);
			}
		}

		/// <summary>
		/// ִ�б���������
		/// </summary>
		/// <param name="obj">ʵ�����</param>
		/// <param name="isForceCommit">
		/// �Ƿ�ǿ��ִ��,Ĭ��Ϊfalse
		/// true:ǿ��ִ�У���������������Ϊ��Ĳ�����Ҳ�����׳��쳣
		/// flase:��ǿ��ִ�У������������Ϊ�㣬���׳��쳣PLException������ΪDirthEntity����ʾ���ڲ�������
		/// </param>
		/// <returns></returns>
		public void DoSaveObject(EntityObject obj,bool isForceCommit)
		{

			if(obj.IsPersistent)
			{
				broker.DoTransaction(obj,ActionTypes.UpdateCommand,rdbs,isForceCommit);
			}
			else
			{
				broker.DoTransaction(obj,ActionTypes.InsertCommand,rdbs,isForceCommit);
			}
		}

		/// <summary>
		/// ִ�б���������������Transaction�趨��IsForceCommit��
		/// </summary>
		/// <param name="obj">����</param>
		public void DoSaveObject(EntityObject obj)
		{
			if(obj.IsPersistent)
			{
				broker.DoTransaction(obj,ActionTypes.UpdateCommand,rdbs,m_IsForceCommit);
			}
			else
			{
				broker.DoTransaction(obj,ActionTypes.InsertCommand,rdbs,m_IsForceCommit);
			}
		}


		/// <summary>
		/// ��������ִ��ʵ��ɾ������
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="isForceCommit">
		/// �Ƿ�ǿ��ִ��,Ĭ��Ϊfalse
		/// true:ǿ��ִ�У���������������Ϊ��Ĳ�����Ҳ�����׳��쳣
		/// flase:��ǿ��ִ�У������������Ϊ�㣬���׳��쳣PLException������ΪDirthEntity����ʾ���ڲ�������
		///</param>
		public void DoDeleteObject(EntityObject obj,bool isForceCommit)
		{
			broker.DoTransaction(obj,ActionTypes.DeleteCommand,rdbs,isForceCommit);
		}

		/// <summary>
		/// ��������ִ��ʵ��ɾ������
		/// </summary>
		/// <param name="obj"></param>
		public void DoDeleteObject(EntityObject obj)
		{
			broker.DoTransaction(obj,ActionTypes.DeleteCommand,rdbs,m_IsForceCommit);
		}

		/// <summary>
		/// �������н���ʵ���ѯ����ִ�к�ʵ�屾��ᱻ����ֵ��
		/// </summary>
		/// <param name="obj">ʵ��</param>
		public void DoRetrieveObject(EntityObject obj)
		{
			broker.DoTransaction(obj,ActionTypes.SelectCommand,rdbs,m_IsForceCommit);
		}


		/// <summary>
		/// ��������ִ��ɾ����׼����
		/// </summary>
		/// <param name="delete">ɾ����׼</param>
		public void DoDeleteCriteria(DeleteCriteria delete)
		{
			broker.DoTransaction(delete,ActionTypes.PesistentCriteria,rdbs,m_IsForceCommit);
		}

		/// <summary>
		/// ��������ִ��ɾ����׼����
		/// </summary>
		/// <param name="delete">ɾ����׼</param>
		/// <param name="isForceCommit">
		/// �Ƿ�ǿ��ִ��,Ĭ��Ϊfalse
		/// true:ǿ��ִ�У���������������Ϊ��Ĳ�����Ҳ�����׳��쳣
		/// flase:��ǿ��ִ�У������������Ϊ�㣬���׳��쳣PLException������ΪDirthEntity����ʾ���ڲ�������
		/// </param>
		public void DoDeleteCriteria(DeleteCriteria delete,bool isForceCommit)
		{
			broker.DoTransaction(delete,ActionTypes.PesistentCriteria,rdbs,isForceCommit);
		}

		/// <summary>
		/// ��������ִ�и��±�׼����
		/// </summary>
		/// <param name="update">���±�׼</param>
		public void DoUpdateCriteria(UpdateCriteria update)
		{
			broker.DoTransaction(update,ActionTypes.PesistentCriteria,rdbs,m_IsForceCommit);
		}


		/// <summary>
		/// ��������ִ��RetrieveCriteria��ѯ
		/// </summary>
		/// <param name="retrieve">��ѯ��׼</param>
		/// <returns></returns>
		public DataTable DoRetrieveCriteria(RetrieveCriteria retrieve)
		{
			return broker.DoRetrieveCriteraTransaction(retrieve,rdbs);
		}

		/// <summary>
		/// ��������ִ�и��±�׼����
		/// </summary>
		/// <param name="update">���±�׼</param>
		/// <param name="isForceCommit">
		/// �Ƿ�ǿ��ִ��,Ĭ��Ϊfalse
		/// true:ǿ��ִ�У���������������Ϊ��Ĳ�����Ҳ�����׳��쳣
		/// flase:��ǿ��ִ�У������������Ϊ�㣬���׳��쳣PLException������ΪDirthEntity����ʾ���ڲ�������
		/// </param>
		public void DoUpdateCriteria(UpdateCriteria update,bool isForceCommit)
		{
			broker.DoTransaction(update,ActionTypes.PesistentCriteria,rdbs,isForceCommit);
		}

		/// <summary>
		/// ��������ִ�зǲ�ѯSQL���
		/// </summary>
		/// <param name="strSql">sql���</param>
		/// <param name="dbName">����Դ����</param>
		public void DoSqlNonQueryString(string strSql,string dbName)
		{
			Hashtable ht=new Hashtable();
			ht.Add("DB",dbName);
			ht.Add("String",strSql);
			broker.DoTransaction(ht,ActionTypes.SqlCommand,rdbs,m_IsForceCommit);
		}

		/// <summary>
		/// ��������ִ�в�ѯSQL���
		/// </summary>
		/// <param name="strSql">SQL���</param>
		/// <param name="dbName">����Դ����</param>
		/// <returns></returns>
		public DataTable DoSqlQueryString(string strSql,string dbName)
		{
			Hashtable ht=new Hashtable();
			ht.Add("DB",dbName);
			ht.Add("String",strSql);
			return broker.DoQueryTransaction(ht,rdbs);
		}

		/// <summary>
		/// ��������ִ��SQL���
		/// </summary>
		/// <param name="strSql">sql���</param>
		/// <param name="dbName">����Դ����</param>
		/// <param name="isForceCommit">
		/// �Ƿ�ǿ��ִ��,Ĭ��Ϊfalse
		/// true:ǿ��ִ�У���������������Ϊ��Ĳ�����Ҳ�����׳��쳣
		/// flase:��ǿ��ִ�У������������Ϊ�㣬���׳��쳣PLException������ΪDirthEntity����ʾ���ڲ������� 
		/// </param>
		public void DoSqlNonQueryString(string strSql,string dbName,bool isForceCommit)
		{
			Hashtable ht=new Hashtable();
			ht.Add("DB",dbName);
			ht.Add("String",strSql);
			broker.DoTransaction(ht,ActionTypes.SqlCommand,rdbs,isForceCommit);
		}


		/// <summary>
		/// �ύ����
		/// </summary>
		/// <returns></returns>
		public bool Commit()
		{
			bool result=true;
			try
			{
				foreach(string key in rdbs.Keys)
				{
					RelationalDatabase rdb=(RelationalDatabase)rdbs[key];
					rdb.CommitTransaction();
				}

				return result;
			}
			catch(Exception e)
			{
				foreach(string key in rdbs.Keys)
				{
					RelationalDatabase rdb=(RelationalDatabase)rdbs[key];
					rdb.RollbackTransaction();
				}
				throw e;

			}
			finally
			{
				//�ر���������
				foreach (string key in rdbs.Keys)
				{
					RelationalDatabase rdb=(RelationalDatabase)rdbs[key];
					rdb.Close();
				}
			
				
			}
			
			
		}

		/// <summary>
		/// �ع�����
		/// </summary>
		public void RollBack()
		{
			try
			{
			
				foreach (string key in rdbs.Keys)
				{
					RelationalDatabase rdb=(RelationalDatabase)rdbs[key];
					rdb.RollbackTransaction();
					
				}
			}
			finally
			{
				//�ر���������
				foreach (string key in rdbs.Keys)
				{
					RelationalDatabase rdb=(RelationalDatabase)rdbs[key];
					rdb.Close();
				}
			
				
			}
		}




		/// <summary>
		///		������������һ��Delete���� 
		/// </summary>
		/// <param name="obj">��Ҫִ��Delete��ʵ�����</param>
		public void AddDeleteObject(EntityObject obj)
		{
			this.tasks.Add(obj);
			this.actions.Add(ActionTypes.DeleteCommand);
		}
		
		/// <summary>
		///		������������һ��Retrieve���� 
		/// </summary>
		/// <param name="obj">��Ҫִ��Retrieve��ʵ�����</param>
		internal void AddRetrieveObject (EntityObject obj)
		{
			this.tasks.Add (obj);
			this.actions.Add (ActionTypes.SelectCommand);
		}

		/// <summary>
		///		������������һ��DeleteCriteria����
		/// </summary>
		/// <param name="delete">DeleteCriteriaʵ��</param>
		public void AddDeleteCriteria(DeleteCriteria delete)
		{
			this.tasks.Add(delete);
			this.actions.Add(ActionTypes.PesistentCriteria);
			//Console.WriteLine("Transaction.AddDeleteCriteria�����У�");
		}

		/// <summary>
		///		������������һ��UpdateCriteria����
		/// </summary>
		/// <param name="update">UpdateCriteriaʵ��</param>
		public void AddUpdateCriteria(UpdateCriteria update)
		{
			this.tasks.Add(update);
			this.actions.Add(ActionTypes.PesistentCriteria);

		}

		/// <summary>
		/// ���SQL����������(�����ݿ�)
		/// add by tintown
		/// </summary>
		/// <param name="sqlstring">ִ�е����</param>
		/// <param name="DbName">���ݿ�����{�߼����ݿ���}</param>
		public void AddSqlString(string sqlstring,string DbName)
		{
			Hashtable ht=new Hashtable();
			ht.Add("DB",DbName);
			ht.Add("String",sqlstring);
			this.tasks.Add(ht);
			this.actions.Add(ActionTypes.SqlCommand);
		}

		/// <summary>
		///		������м��뵽������Ķ��� 
		/// </summary>
		public void Clear()
		{
			this.tasks.Clear();
			this.actions.Clear();
		}
		
		/// <summary>
		///		������ 
		/// </summary>
		/// <returns>�������ɹ�����true��ʧ�ܷ���false</returns>
		public bool Process()
		{
			bool result=true;
			try
			{
				PersistenceBroker broker=PersistenceBroker.Instance();
				//if (broker.MultiDatabase )
				//{
					result=broker.ProcessTransactionMultiDatabases (this);
				//}
				//else
				//{
				//	broker.ProcessTransactionSingleDatabase (this);
				//}
			}
			catch(Exception e)
			{
				result=false;
				throw e;
			}
			return result;
		}



		/*����*/
		/// <summary>
		///		��������������еĶ�����Ŀ
		/// </summary>
		public int Count
		{
			get
			{
				return this.tasks.Count;
			}
		}

		/// <summary>
		/// tintown added at 2005-3-23
		/// �����ж��Ƿ�ǿ��Commit��Ĭ��Ϊfalse
		/// flase:��ǿ��Commit����ָ��ʵ��Save()����ʵ��Delete()ʱ������false�ͻع���������,�����ڲ����Դ���
		/// true:ǿ��Commit,��ָ����ʵ��Save()��Delete()���ص�false״̬����Ϊ��ʱ����ҵ���ϱ����������ġ�
		/// </summary>
		public bool IsForceCommit
		{
			get
			{
				return this.m_IsForceCommit;
			}
			set
			{
				this.m_IsForceCommit=true;
			}
		}

			internal IList Tasks
		{
			get{return this.tasks;}
		}
		internal IList Actions
		{
			get{return this.actions;}
		}
	}


}
