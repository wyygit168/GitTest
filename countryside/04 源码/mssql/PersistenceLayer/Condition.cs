using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	///		���ඨ�������޶�����Χ��ѡ���������û�����ֱ����������ʵ����
	///		��Ҫ�õ�Conditon����Ҫͨ��RetrieveCriteria��DeleteCriteria��GetNewConditon()������
	///		Condition�ڲ���"AND"��ϵ��Condition��Condition֮����"OR"�Ĺ�ϵ���磺
	///		RetrieveCriteria rc=new RetrieveCrititeria(typeof(aEntity));
	///		Condition c1=rc.GetNewCondition();
	///		c1.AddEqualTo(aEntity.Name,"����");
	///		c1.AddEqualTo(aEntity.Age,"27");
	///		Condtion c2=rc.GetNewCondition();
	///		c2.AddEqualTo(aEntity.City,"����");
	///		���������ɵĲ�ѯ�ǣ�where (Name="����" and Age=27) or (City="����")
	///		��Ϊ������"(a or b) and c"������ʽ������ο�GetOrGroup()����
	/// </summary>
	public class Condition
	{
		private const string NO_NULLl="���ܴ���Null!";
		private const string NO_FIELD="ָ�ֵıȽ��ֶ���������";

		private IList parameters = new ArrayList ();
		private ClassMap _classMap = null;
		private string booleanOperator = " AND ";

		internal Condition(Type entityObject)
		{

		}
		internal Condition (ClassMap clsMap)
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
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
			this.parameters.Add(criteria);
		}

		/// <summary>
		/// "="�Ƚ������ֶ��Ƿ����
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
				this._classMap.GetAttributeMap (attributeName,true),attributeValue,_classMap);
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
		/// "�����"�Ƚ������ֶ��Ƿ����
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
		///		ָ�����ַ�����ָ������ƥ��
		/// </summary>
		/// <param name="attributeName">����</param>
		/// <param name="attributeValue">ָ���ַ���</param>
		public void AddNotMatch(string attributeName,string attributeValue)
		{
			if (attributeValue==null) 
				throw new PlException(NO_NULLl);
			SelectionCriteria criteria;
			attributeValue="%"+attributeValue+"%";
			criteria=new SelectionCriteria(SelectionTypes.NotMatch,
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
		/// ����һ��OrGroup����
		/// </summary>
		/// <returns></returns>
		public OrGroup GetNewOrGroup()
		{
			OrGroup orgroup=new OrGroup(this._classMap);
			this.parameters.Add(orgroup);
			return orgroup;
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
	}
}
