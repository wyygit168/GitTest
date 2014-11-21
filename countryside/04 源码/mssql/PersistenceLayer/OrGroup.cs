using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// OrGroup��Condition���÷�������һ�µ�
	/// OrGroup�ڲ�����"AND"��ϵ
	/// Ϊ��ʵ��(a or b ) and c������Ч����a������b����֮����or��ϵ������c����and���
	/// ����cΪ�Ѿ�ʵ�����Ķ���
	/// OrGroup og=c.GetOrGroup();
	/// og.AddEqualTo(...)  //����a
	/// og.AddEqualTo(...)  //����b
	/// c.AddEuqalTo(...)   //����c
	/// </summary>
	public class OrGroup
	{

		private const string NO_NULLl="���ܴ���Null!";
		private const string NO_FIELD="ָ�ֵıȽ��ֶ���������";

		private IList parameters = new ArrayList ();
		private ClassMap _classMap = null;
		private string booleanOperator = " OR ";

	
		internal OrGroup(Type entityObject)
		{

		}
		internal OrGroup (ClassMap clsMap)
		{
			this._classMap = clsMap;
		}


		/// <summary>
		///		��=���Ƚ�ָ��ֵ��ָ������
		/// </summary>
		/// <param name="attributeName">�Ƚϵ�����</param>
		/// <param name="attributeValue">ָ��ֵ</param>
		public void AddEqualTo(string attributeName,object attributeValue)
		{
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.EqualTo,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,this._classMap);
			this.parameters.Add(criteria);
		}

		/// <summary>
		/// "="�Ƚ������ֶ��Ƿ���ȡ�
		/// </summary>
		/// <param name="attributeName">��һ���ֶ���</param>
		/// <param name="attributeName2">�ڶ����ֶ���</param>
		public void AddEqualToField(string attributeName,string attributeName2)
		{
			if (attributeName2==null) 
				throw new PlException(NO_FIELD);
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.EqualTo,
				this._classMap.GetAttributeMap (attributeName,true),this._classMap.GetAttributeMap (attributeName2,true),_classMap);
			this.parameters.Add(criteria);
		}
		
		/// <summary>
		///		��>���Ƚ�ָ��ֵ��ָ������
		/// </summary>
		/// <param name="attributeName">�Ƚϵ�����</param>
		/// <param name="attributeValue">ָ��ֵ</param>
		public void AddGreaterThan(string attributeName,object attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.GreaterThan,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);
		}

		/// <summary>
		/// ">"�Ƚϵ�һ���ֶ��Ƿ���ڵڶ����ֶ�
		/// </summary>
		/// <param name="attributeName">��һ���ֶ�����</param>
		/// <param name="attributeName2">�ڶ����ֶ�����</param>
		public void AddGreaterThanField(string attributeName,string attributeName2)
		{
			if (attributeName2==null) 
				throw new PlException(NO_FIELD);
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.GreaterThan,
				this._classMap.GetAttributeMap (attributeName,true),this._classMap.GetAttributeMap (attributeName2,true),_classMap);
			this.parameters.Add(criteria);
		}
		
		/// <summary>
		///		��>=���Ƚ�ָ��ֵ��ָ������
		/// </summary>
		/// <param name="attributeName">�Ƚϵ�����</param>
		/// <param name="attributeValue">ָ��ֵ</param>
		public void AddGreaterThanOrEqualTo(string attributeName,object attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);			
			SelectionCriteria criteria;
			criteria = new SelectionCriteria (SelectionTypes.GreaterThanAndEqualTo,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,this._classMap);
			this.parameters.Add(criteria);
		}

		/// <summary>
		/// ">="�Ƚϵ�һ���ֶ��Ƿ���ڵ��ڵڶ����ֶ�
		/// </summary>
		/// <param name="attributeName">��һ���ֶ�����</param>
		/// <param name="attributeName2">�ڶ����ֶ�����</param>
		public void AddGreaterThanOrEqualToField(string attributeName,string attributeName2)
		{
			if (attributeName2==null) 
				throw new PlException(NO_FIELD);			
			SelectionCriteria criteria;
			criteria = new SelectionCriteria (SelectionTypes.GreaterThanAndEqualTo,
				this._classMap.GetAttributeMap (attributeName,true),this._classMap.GetAttributeMap (attributeName2,true),_classMap);
			this.parameters.Add(criteria);
		}



		/// <summary>
		///		�������ڡ�"�Ƚ�ָ��ֵ��ָ������
		/// </summary>
		/// <param name="attributeName">�Ƚϵ�����</param>
		/// <param name="attributeValue">ָ��ֵ</param>
		public void AddNotEqualTo(string attributeName,object attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);		
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.NotEqualTo,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);
		}

		/// <summary>
		/// "������"�Ƚ������ֶ��Ƿ����
		/// </summary>
		/// <param name="attributeName">��һ���ֶ�����</param>
		/// <param name="attributeName2">�ڶ����ֶ�����</param>
		public void AddNotEqualToField(string attributeName,string attributeName2)
		{
			if (attributeName2==null) 
				throw new PlException(NO_FIELD);		
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.NotEqualTo,
				this._classMap.GetAttributeMap (attributeName,true),this._classMap.GetAttributeMap (attributeName2,true),_classMap);
			this.parameters.Add(criteria);
		}

		/// <summary>
		///		��С�ڡ��Ƚ�ָ��ֵ��ָ������
		/// </summary>
		/// <param name="attributeName">�Ƚϵ�����</param>
		/// <param name="attributeValue">ָ��ֵ</param>
		public void AddLessThan(string attributeName,object attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.LessThan,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}	   

		/// <summary>
		/// "С��"�Ƚϵ�һ���ֶ��Ƿ�С�ڵڶ����ֶ�
		/// </summary>
		/// <param name="attributeName">��һ���ֶ�����</param>
		/// <param name="attributeName2">�ڶ����ֶ�����</param>
		public void AddLessThanField(string attributeName,string attributeName2)
		{
			if (attributeName2==null) 
				throw new PlException(NO_FIELD);	
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.LessThan,
				this._classMap.GetAttributeMap (attributeName,true),this._classMap.GetAttributeMap (attributeName2,true),_classMap);
			this.parameters.Add(criteria);		
		}	   

		/// <summary>
		///		�� С�ڵ��� ��"�Ƚ�ָ��ֵ��ָ������
		/// </summary>
		/// <param name="attributeName">�Ƚϵ�����</param>
		/// <param name="attributeValue">ָ��ֵ</param>
		public void AddLessThanOrEqualTo(string attributeName,object attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.LessThanAndEqualTo,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}		

		/// <summary>
		/// "С�ڵ���"�Ƚϵ�һ���ֶ��Ƿ�С�ڵ��ڵڶ����ֶ�
		/// </summary>
		/// <param name="attributeName">��һ���ֶ�</param>
		/// <param name="attributeName2">�ڶ����ֶ�</param>
		public void AddLessThanOrEqualToField(string attributeName,string attributeName2)
		{
			if (attributeName2==null) 
				throw new PlException(NO_FIELD);	
			SelectionCriteria criteria;
			criteria=new SelectionCriteria (SelectionTypes.LessThanAndEqualTo,
				this._classMap.GetAttributeMap (attributeName,true),this._classMap.GetAttributeMap (attributeName2,true),_classMap);
			this.parameters.Add(criteria);		
		}		

		/// <summary>
		///		ָ�����ַ�����ָ����ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="attributeValue">ָ���ַ���</param>
		public void AddMatch(string attributeName,string attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);
			SelectionCriteria criteria;
			attributeValue="%"+attributeValue+"%";
			criteria=new SelectionCriteria(SelectionTypes.Match,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}		
		
		/// <summary>
		///		ǰ׺ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="attributeValue">ƥ��ֵ</param>
		public void AddMatchPrefix(string attributeName,string attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);

			SelectionCriteria criteria;
			attributeValue=attributeValue+"%";
			criteria=new SelectionCriteria(SelectionTypes.MatchPrefix,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}		

		/// <summary>
		///		ǰ׺��ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="attributeValue">ƥ��ֵ</param>
		public void AddNotMatchPrefix(string attributeName,string attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);

			SelectionCriteria criteria;
			attributeValue=attributeValue+"%";
			criteria=new SelectionCriteria(SelectionTypes.NotMatchPrefix,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}	

		/// <summary>
		///		��׺ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="attributeValue">ƥ��ֵ</param>
		public void AddMatchSuffix(string attributeName,string attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);

			SelectionCriteria criteria;
			attributeValue="%"+attributeValue;
			criteria=new SelectionCriteria(SelectionTypes.MatchSuffix,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}		

		/// <summary>
		///		��׺��ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="attributeValue">ƥ��ֵ</param>
		public void AddNotMatchSuffix(string attributeName,string attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);

			SelectionCriteria criteria;
			attributeValue="%"+attributeValue;
			criteria=new SelectionCriteria(SelectionTypes.NotMatchSuffix,
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);		
		}	

		/// <summary>
		///		��������б�list���ֵƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="list">ֵ�б�</param>
		public void AddIn (string attributeName , object[] list)
		{
			if (list == null || list.Length == 0) 
				throw new PlException("�����list���Ȳ���Ϊ0��");
			SelectionCriteria selection = new SelectionCriteria (SelectionTypes.In,
				this._classMap.GetAttributeMap (attributeName,true),list,_classMap);
			this.parameters.Add (selection);
		}

		/// <summary>
		///		��������б�list���ֵ��ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="list">ֵ�б�</param>
		public void AddNotIn (string attributeName , object[] list)
		{
			if (list == null || list.Length == 0) 
				throw new PlException("�����list���Ȳ���Ϊ0��");
			SelectionCriteria selection = new SelectionCriteria (SelectionTypes.NotIn,
				this._classMap.GetAttributeMap (attributeName,true),list,_classMap);
			this.parameters.Add (selection);
		}

		/// <summary>
		///		�����������
		/// </summary>
		public void Clear ()
		{
			this.parameters.Clear ();
		}

		/*����*/
		//Where��������
		internal IList Parameters 
		{
			get{return this.parameters;}
		}

		internal string BooleanOperator
		{
			get {return this.booleanOperator;}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		internal string AsSqlClause()
		{
			string sql="";
			string sqlPre="(";
			string sqlfix=")";
			SelectionCriteria selection;
			int size = this.parameters.Count;
			if (size > 0)
			{
				sql=sqlPre;
				for(int i=0;i<size;i++)
				{
					if(i>0)
						sql += this.booleanOperator;
					selection = (SelectionCriteria)this.Parameters [i];
					sql += selection.AsSqlClause ();
				}
				sql +=sqlfix;
			}
			
			return sql;
		}

	}
	
}
