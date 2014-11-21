using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// EntityContainerʵ�����������
	/// ��RetrieveCriteria���ɣ�����rcΪһ��RetrieveCriteriaʵ������
	/// EntityContainer ec=rc.AsEntityContainer();
	/// for(int i=0;i<ec.Count;++)
	/// {
	///		aEntity a=(aEntity)ec[i];
	///		.....
	/// }
	/// </summary>
	[Serializable]
	public class EntityContainer : ArrayList
	{
		/// <summary>
		/// ���캯��
		/// </summary>
		public EntityContainer()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		/// <summary>
		/// ��Ӷ���
		/// </summary>
		/// <param name="entity"></param>
		public void Add(EntityObject entity)
		{
			base.Add(entity);
		}

	
		/// <summary>
		/// ��N������
		/// </summary>
		public new EntityObject this[int index]
		{
			get
			{
				return (EntityObject)base[index];
				
			}
						
		}

//		public DataTable AsDataTable()
//		{
//			DataTable dt=new DataTable();
//			DataRow dr;
//			AttributeMap am;
//			EntityObject entity;
//			ClassMap cm=PersistenceBroker.Instance().GetClassMap(entity.GetClassName());
//			int count = cm.SelfClassAttributes.Count;
//			for(int i=0;i<count;i++)
//			{
//				am = (AttributeMap) cm.SelfClassAttributes[i];
//				dt.Columns.Add(am.Name,typeof(string));
//					
//			}
//
//			for(int i=0;i<this.Count;i++)
//			{
//				dr=dt.NewRow();
//				
//				for(int ii=0;ii<count;ii++)
//				{
//					am = (AttributeMap) cm.SelfClassAttributes[i];
//					dr[am.Name]=entity.GetAttributeValue(am.Name);
//				}
//			}
//			return dt;
//		}
	
			
	}
}
