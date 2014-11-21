using System;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// ���󼯺��α��࣬һ����RetrieveCriteria�д�����
	///  ObjectCursor oc=rc.AsObjectCursor();���α�ָ���ȡ���Ķ���
	///  for(oc.HasObject()) //ѭ���жϣ����ʹ��EntityContainer������
	/// {
	///	 entity e=(entity)oc.NextObject();
	/// }
	/// </summary>
	public class ObjectCursor
	{
		private int size;
		private int pointer;
		private bool m_IsIncludeAssociation = false;
		private DataSet results;
		private Type typeOfClass;
		private string className;
		private PersistenceBroker broker = PersistenceBroker.Instance();
		
		

		internal ObjectCursor(Type classType,DataSet ds,bool isIncludeAssociation)
		{
			this.results=ds;
			this.size=ds.Tables[0].Rows.Count;
			this.pointer=0;
			this.typeOfClass=classType;
			string name=classType.ToString();
			this.className=name.Substring(name.LastIndexOf('.')+1);
			this.m_IsIncludeAssociation = isIncludeAssociation;
			

		}

		internal ObjectCursor(Type classType,DataTable dt,bool isIncludeAssociation)
		{
			this.results = new DataSet ();
			this.results.Tables.Add (dt);
			this.size=dt.Rows.Count;
			this.pointer=0;
			this.typeOfClass=classType;
			string name=classType.ToString();
			this.className=name.Substring(name.LastIndexOf('.')+1);
			this.m_IsIncludeAssociation = isIncludeAssociation;
			

		}

		internal ObjectCursor (string name,DataTable dt,bool isIncludeAssociation)
		{
			this.results = new DataSet ();
			this.results.Tables.Add (dt);
			this.m_IsIncludeAssociation = isIncludeAssociation;
		}

		/// <summary>
		///		������һ���������
		/// </summary>
		/// <returns>EntityObject</returns>
		public EntityObject NextObject()
		{	
			EntityObject aObject=null;
			try
			{
				aObject=broker.GetEntityObject(typeOfClass,className,results.Tables[0].Rows[pointer]);
				//broker.RetrieveObject(aObject,this.m_IsIncludeAssociation);//�Ժ������޸�
            }
			catch (IndexOutOfRangeException)
			{
				throw new PlException("�Ѿ�û��ʵ��������ö���ˣ�");
			}
			
			this.pointer++;
			return aObject;
		}


		/// <summary>
		///		�Ƿ��ж���	 
		/// </summary>
		/// <returns>true�����ж���false���޶���</returns>
		public bool HasObject()
		{
			bool r=true;
			if(this.pointer>=this.size) r=false;
			return r;
		}

		/// <summary>
		///		��ָ���ƶ�����һ��ʵ����� 
		/// </summary>
		public void MoveFirst()
		{
			this.pointer = 0;
		}

		//������
//		public EntityObject this [int index]
//		{
//			get
//			{
//				return ((EntityObject) this.m_Collection [index]);
//			}
//		}

		
		/*����*/
		/// <summary>
		///		������ʵ����������
		/// </summary>
		public int Count
		{
			get {return this.size;}
		}

	}
}
