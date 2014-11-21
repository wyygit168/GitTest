using System;

namespace PersistenceLayer
{
	/// <summary>
	///		CardinalityTypes ��ժҪ˵����
	/// </summary>
	enum CardinalityTypes
	{
		None,
		OneToOne,
		OneToMany
	}

	/// <summary>
	///		ActionTypes ��ժҪ˵����
	///		tintown Add "SqlCommand" at 2004-09-06
	///		��Ӵ���SQL���������
	/// </summary>
	enum ActionTypes
	{
		InsertCommand,
		SelectCommand,
		UpdateCommand,
		DeleteCommand,
		SqlCommand,
		/// <summary>
		///		�����׼
		/// </summary>
		PesistentCriteria,
	
		RetrieveCriteria
	}

	/// <summary>
	///		ColumnKeyTypes ���ݱ�Column�ļ�����
	/// </summary>
	enum ColumnKeyTypes
	{
		NoneKey,				//���Ǽ�
		PrimaryKey,				//����
		ForeignKey				//���
	}
	
	/// <summary>
	///		ʵ����������
	/// </summary>
	public enum ErrorTypes 
	{
		
		/// <summary>��ʽ����</summary>
		FormatException,
		/// <summary>δ����</summary>
		NotFound,			
		/// <summary>Xml�ļ�����</summary>
		XmlError,					
		/// <summary>δ֪���� </summary>
		Unknown,
		/// <summary>���ݿ����</summary>
		DatabaseError,
		
		/// <summary>
		/// ���ݿⲻ���ڴ���
		/// </summary>
		DatabaseConnectionError,
		
		/// <summary>���ݿ�δ�������</summary>
		DatabaseUnknwnError,		
		/// <summary>���ݲ�Ψһ��ԭ������Ǳ�ʶ������¼�������������ظ�</summary>
		NotUnique,					
		/// <summary>���ݹ���</summary>
		DataTooLong,				
		/// <summary>�ַ�������Ϊ�㳤��</summary>
		NotAllowStringEmpty,		
		/// <summary>���ݲ���Ϊ��</summary>
		NotAllowDataNull,			
		/// <summary>�������Ͳ�ƥ��</summary>
		DataTypeNotMatch,
		/// <summary>�Զ�����ֵ������ָ��</summary>
		AutoValueOn,
		/// <summary>����ʧ�ܣ�ԭ������������ѱ�ɾ�����������ݱ��������޸�</summary>
		UpdateFail,		
		/// <summary>����Լ�����ƣ����µĴ���</summary>
		RestrictError,
		/// <summary>ȱ�ٱ�Ҫ������(null)�����ʶ�ö��������</summary>
		RequireAttribute,

		/// <summary>ʵ���һ����� </summary>
		PesistentError,

		/// <summary>
		/// �������������ݣ������ǲ��������
		/// </summary>
		DirtyEntity
	
	}

	enum SelectionTypes
	{
		EqualTo,								//  = 
		GreaterThan,							//  > 
		GreaterThanAndEqualTo,					//  >=
		NotEqualTo,								//  <>
		LessThan,								//  < 
		LessThanAndEqualTo,						//  <=
		Match,									//  LIKE %..%
		MatchPrefix,							//  LIKE %...
		In,										//  IN	
		NotMatch,
		NotMatchPrefix,
		NotIn,
		MatchSuffix,
		NotMatchSuffix
	}

	/// <summary>
	/// ��׼����
	/// </summary>
	internal enum CriteriaTypes
	{

		Retrive,								//RetrieveCritera
		Delete,									//DeleteCriteria
		Update									//UpdateCriteria
	}

	enum SqlValueTypes
	{
		/// <summary>�ַ�����</summary>
		PrototypeString,
		/// <summary>'xxxx'�͵��ַ���</summary>
		SimpleQuotesString,
		String,
		BoolToString,
		BoolToInterger,
		AccessDateString,
		NotSupport,
		OracleDate
	}

	/// <summary>
	/// ���巵����������
	/// ��RetrieveCriteria�п���ʹ��
	/// </summary>
	public enum AttributeType
	{
		/// <summary>
		/// �������е��ֶ�
		/// ���൱��"*"����
		/// </summary>
		All=0                //��Query�����ڷ�����������
	}
}
