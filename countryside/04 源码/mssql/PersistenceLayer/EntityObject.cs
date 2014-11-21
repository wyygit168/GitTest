using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace PersistenceLayer
{
	/// <summary>
	///		����ʵ����Ļ���,����ʵ���඼�Ӵ˼̳�
	///	</summary>
	[Serializable]
	public abstract class EntityObject  
	{
		
		private bool persistent=false;
		
	

		/// <summary>
		/// ʵ���Լ�������Դ���ڽ���ʵ��Ĳ���ʱ��ʹ�ô����ݿ�
		/// �Ա���ʵ�嶯̬�Ľ��в�ͬ���ݿ�Ĵ�ȡ
		/// tintown add by 2004-10-23
		/// </summary>
		private string _databaseName;	

		/// <summary>
		/// ʵ���Ƿ�Ҫ���浽�ڴ��У���XML�ж�ȡ��ֵ
		/// </summary>
		private bool _IsSaveInMemory=false;

		private string _memoryKey="";
	
//		private string _dirtyKey="";
//		private string _dirtyCode="";
//		private bool _dirtyUpdate=false;

		//
		// ��ǰEntityObject�����System.Type����
		//
		private Type thisType;

		/// <summary>
		///		����Type�����classType�Ķ�����
		/// </summary>
		public static string GetClassName(Type classType)
		{
			string name=classType.ToString();
			return name.Substring(name.LastIndexOf('.')+1);
		}

		/// <summary>
		///		constructor
		/// </summary>
		public EntityObject()
		{
			this.thisType = this.GetType ();
			this._IsSaveInMemory =PersistenceBroker.Instance().GetClassMap(thisType.Name).IsSaveToMemory;
			
			
		}

	
		/// <summary>
		///		���ض�������� 
		/// </summary>
		internal virtual string GetClassName()
		{
			string name=this.ToString();
			return name.Substring(name.LastIndexOf('.')+1);
		}

		/// <summary>
		///	ʹ����ʵ�廯,����IsPersistent�����Ǹ��»��ǲ������
		///	���IsPersistentΪTrue�����Զ������Update��������ʹ��Retrieve()����Զ����ϴ�ֵ���磺
		///	entity.Retrieve();
		///	if(entity.IsPersistent)
		///	{����и��²���}
		///	��ȻIsPersistent��public�ģ���һ�������£���������и�ֵ��
		/// </summary>
		public int Save()
		{
			
			PersistenceBroker broker=PersistenceBroker.Instance();
			this._IsSaveInMemory =broker.GetClassMap(thisType.Name).IsSaveToMemory;
			return broker.SaveObject(this);
		}
		/// <summary>
		///	���ݶ����������ȡΨһ����
		/// ע�⣬�������������ֻ��ͨ����������ȡ����Ϊֻ���������߼���ȷ��Ψһ
		/// ֧��˫�����������˫�������������������Ա��붼Ҫ����
		/// �������ͨ������Ψһȷ���ģ������ͨ��RetrieveCriteria��������ȡ��
		/// </summary>
		/// <returns></returns>
		public bool Retrieve()
		{
			PersistenceBroker broker=PersistenceBroker.Instance();
			this._IsSaveInMemory =broker.GetClassMap(thisType.Name).IsSaveToMemory;
			return broker.RetrieveObject(this,true);
		}
		/// <summary>
		///		��ȡ���� ��ѡ���Ƿ���ͬ��������Ķ���һ���ȡ
		/// </summary>
		/// <returns></returns>
//		public bool Retrieve(bool isRetrieveAssociation)	
//		{
//			PersistenceBroker broker=PersistenceBroker.Instance();
//			this._IsSaveInMemory =broker.GetClassMap(thisType.Name).IsSaveToMemory;
//			return broker.RetrieveObject(this,isRetrieveAssociation);
//		}
		/// <summary>
		///		ɾ�� 
		/// </summary>
		public int Delete()	
		{
			PersistenceBroker broker=PersistenceBroker.Instance();
			this._IsSaveInMemory =broker.GetClassMap(thisType.Name).IsSaveToMemory;
			return broker.DeleteObject(this);
		}

		//������������̬�õ�����ֵ		
		internal object GetAttributeValue(string name)
		{
			object rObject=null;
			try
			{
				rObject = this.thisType.InvokeMember(name,BindingFlags.GetProperty,null,this,null);
			}
			catch
			{
				throw new PlException("�����ҵ�"+GetClassName()+"�����["+name+"]����!",ErrorTypes.NotFound);
			}
			return rObject;
		}

	
		/// <summary>
		/// ������������̬��������ֵ
		/// </summary>
		/// <param name="name"></param>
		/// <param name="objValue"></param>
		public void SetAttributeValue(string name,object objValue)
		{
			object[] objectsValue=new object[1];
			System.Type tp=this.thisType.GetProperty(name).PropertyType;
			objectsValue[0] =Convert.ChangeType(objValue, tp);
			try
			{
				this.thisType.InvokeMember(name,BindingFlags.SetProperty,null,this,objectsValue);
			}
			catch(Exception e)
			{
				throw e;
			}

		}
		
		/*����*/
		/// <summary>
		///		ָʾ��ʵ������Ƿ��Ѿ�ʵ�廯��
		///		true���ʾ��Saveʱִ��Update������false���ʾ��Saveʱִ��Insert������
		/// </summary>
		public bool IsPersistent
		{
			get{return this.persistent;}
			set{this.persistent=value;}
		}

	

		/// <summary>
		/// ����Դ����
		/// </summary>
		public string DatabaseName
		{
			get
			{
				if(this._databaseName==null)
					this._databaseName=PersistenceBroker.Instance().GetClassMap(GetClassName()).Database.Name;
				return this._databaseName;
			}
			set
			{

				this._databaseName=value;
			}
		}

		internal bool IsSaveToMemory
		{
			set
			{
				this._IsSaveInMemory=value;
			}
			get
			{
				return this._IsSaveInMemory;
			}
		}

		internal string MemoryKey
		{
			set
			{this._memoryKey=value;}
			get
			{
				this._memoryKey=this.DatabaseName +"_"+this.thisType.Name;
				return this._memoryKey;
			}
		}

		/// <summary>
		/// ����������ʵ������Clone�����ض�������ǿ��ת��һ�¾Ϳ���ʹ��
		/// ע�⣺ʵ���������ǡ������л��ġ�,��ʵ����Ҫ����[Serializable]���Է���ʹ�á�
		/// </summary>
		/// <returns></returns>
		public EntityObject DeepClone()
		{
		
			using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
			{
				BinaryFormatter formatter=new BinaryFormatter();
				formatter.Serialize(stream,this);
				stream.Position = 0;
				return (EntityObject)formatter.Deserialize(stream);
			}
		
		}

		

	}
}
