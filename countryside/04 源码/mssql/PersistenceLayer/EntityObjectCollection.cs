using System;
using System.Collections;

namespace PersistenceLayer
{
	/// <summary>
	///		EntityObject���󼯺ϡ�����ʵ��ʵ����֮���1-N�Ĺ�����
	///		�����Ǹ������಻��ֱ��ʵ����������Ҫ�Ӹ����������õ�һ��ǿ���͵Ķ��󼯺ϡ�
	/// </summary>
	internal abstract class EntityObjectCollection
	{
		private ArrayList m_Collection ;
		private Type m_EntityObjectType;
		private string m_FullName;

		/// <summary>
		///		����һ��EntityObjectCollectionʵ��
		/// </summary>
		/// <param name="entityObjectType"></param>
		public EntityObjectCollection (Type entityObjectType)
		{
			m_Collection = new ArrayList();
			this.m_EntityObjectType = entityObjectType;
			this.m_FullName = this.m_EntityObjectType.ToString();
			//this.m_NameSpace = this.m_NameSpace.Substring(0,this.m_NameSpace.LastIndexOf('.'));
		}
		
		/// <summary>
		///		����һ��ʵ����� 
		/// </summary>
		/// <param name="aEntityObject">���뼯�ϵ�ʵ�����</param>
		public void Add ( EntityObject aEntityObject)
		{
			this.m_Collection.Add (aEntityObject);
		}

		/// <summary>
		///		�Ƴ�һ��ʵ�����
		/// </summary>
		public void Remove (EntityObject aEntityObject)
		{
			this.m_Collection.Remove (aEntityObject);
		}
		
		/// <summary>
		///		Ҫ�Ƴ���ʵ�������㿪ʼ������
		/// </summary>
		/// <param name="index">����</param>
		public void RemoveAt (int index)
		{
			this.m_Collection.RemoveAt (index);
		}

		/// <summary>
		///		�Ƴ������е����ж���
		/// </summary>
		public void Clear()
		{
			this.m_Collection.Clear ();
		}
		/// <summary>
		///		������
		/// </summary>
		/// <param name="index">������</param>
		/// <returns>����ʵ�����</returns>
		public EntityObject Items (int index)
		{
			return ((EntityObject) this.m_Collection [index]);
		}

		/// <summary>
		///		ʵ���������
		/// </summary>
		public int Count 
		{
			get
			{
				return this.m_Collection.Count;
			}
		}

		/// <summary>
		///		�ü���������ʵ������Typeʵ����
		/// </summary>
		public Type EntityObjectType
		{
			get
			{
				return this.m_EntityObjectType;
			}
		}

		/// <summary>
		///		�ü���������ʵ������������
		/// </summary>
		public string FullName
		{
			get {return this.m_FullName;}
		}

		internal ArrayList Objects
		{
			get {return this.m_Collection;}
		}

	}
}
