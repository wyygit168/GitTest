using System;
using System.Data.OleDb;

namespace PersistenceLayer
{
	/// <summary>
	///		PlException ʵ����Ʋ��쳣����ʵ��㷢�����쳣������PlExcetion�쳣�׳���
	/// </summary>
	public class PlException:Exception
	{
		private ErrorTypes m_ErrorType;
		private Exception  m_ErrorSource;

		/// <summary>
		///		����һ��PlException�쳣ʵ��
		/// </summary>
		/// <param name="message">�쳣��Ϣ</param>
		public PlException(string message):base(message)
		{
			this.m_ErrorType = ErrorTypes.Unknown;
		}
		
		/// <summary>
		///		����һ��PlException�쳣ʵ��
		/// </summary>
		/// <param name="message">�쳣��Ϣ</param>
		/// <param name="errorType">�쳣����</param>
		public PlException(string message,ErrorTypes errorType):base(message)
		{
			this.m_ErrorType = errorType;
		}

		/// <summary>
		///		����һ��PlException�쳣ʵ��
		/// </summary>
		/// <param name="e">�쳣ʵ��</param>
		public PlException(Exception e):base("ʵ���δ����Ĵ���")
		{
			this.m_ErrorType=ErrorTypes.Unknown;
			this.m_ErrorSource=e;
		}

		/*����*/
		
		/// <summary>
		///		���ص�ǰPlExcetpionʵ���Ĵ������(ö������)
		/// </summary>
		public ErrorTypes ErrorType
		{
			get{return this.m_ErrorType;}
		}
		
		/// <summary>
		///		���������׳�PlExcetpion��Exception������PlException�޷��õ��㹻�Ĵ�����Ϣ��
		///		�ɴ������������쳣��ԭʼException��
		/// </summary>
		public Exception ErrorSource
		{
			get{return this.m_ErrorSource;}
		}
	}


}
