using System;
using System.Collections;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// SelectionCriteria ��ժҪ˵����
	/// </summary>
	class SelectionCriteria
	{
		private SelectionTypes type;
		private string attrName;
		private object attrValue;
		private AttributeMap _atrribute;
		//add by tintown 
		//�����ж��Ƿ����ֶαȽ��ֶ�,Ĭ��Ϊ��
		private bool _isFieldToField=false;
		private AttributeMap _attribute2 =null;

		private ClassMap clsMap;

		//Constructor
		public SelectionCriteria(SelectionTypes criteriaType,string attributeName,object attributeValue,ClassMap clsMap)
		{
			this.type=criteriaType;
			this.attrName=attributeName;
			this.attrValue=attributeValue;
			this.clsMap=clsMap;
		}

		public SelectionCriteria (SelectionTypes selection ,AttributeMap attribute ,object attributeValue,ClassMap clsMap)
		{
			this.type = selection;
			this._atrribute = attribute;
			this.attrValue = attributeValue;
			this.clsMap=clsMap;
		}

		//add by tintown
		//���ڽ����ֶ����ֶεıȽ�
		public SelectionCriteria (SelectionTypes selection ,AttributeMap attribute ,AttributeMap attribute2,ClassMap clsMap)
		{
			this.type = selection;
			this._atrribute = attribute;
			this._isFieldToField=true;
			this._attribute2=attribute2;
			this.clsMap=clsMap;
		}
		
		public string AsSqlClause ()
		{
			string s;
			string columnName=clsMap.GetFullyQualifiedName(this._atrribute.Column.Name );
			s = columnName;
			switch(type)
			{
				case SelectionTypes.EqualTo:
					//tintown ��ӵ�����Nullֵ����
					if (attrValue == System.DBNull.Value )
					{						
						s +=" is null";
					
					}
					else
						s += "=";
					break;
				case SelectionTypes.GreaterThan:
					s += ">";
					break;
				case SelectionTypes.GreaterThanAndEqualTo:
					s += ">=";
					break;
				case SelectionTypes.NotEqualTo:
					if (attrValue == System.DBNull.Value )
					{					
						s +=" is not null";						

					}
					else
						s += "<>";
					break;
				case SelectionTypes.LessThan:
					s += "<";
					break;
				case SelectionTypes.LessThanAndEqualTo:
					s += "<=";
					break;
				case SelectionTypes.Match:
				case SelectionTypes.MatchSuffix:
				case SelectionTypes.MatchPrefix:
					s += " LIKE ";
					break;
				case SelectionTypes.NotMatch:
				case SelectionTypes.NotMatchPrefix:
				case SelectionTypes.NotMatchSuffix:
					s += " NOT LIKE ";
					break;

//				case SelectionTypes.MatchPrefix:
//					s += " LIKE ";	
//					break;
//				case SelectionTypes.NotMatchPrefix:
//					s += " NOT LIKE ";	
//					break;
				case SelectionTypes.In:
					s += " IN (";
					object[] list = (object[])this.attrValue;
					s += this.StringOfInCrtieria (list) + ")";
					return s;
				case SelectionTypes.NotIn:
					s += " NOT IN (";
					object[] list1 = (object[])this.attrValue;
					s += this.StringOfInCrtieria (list1) + ")";
					return s;
				default:
					s += "";
					break;
			}
			//add by tintown
			if(this._isFieldToField) //������ֶ����ֶαȽ�
			{
				s=s + clsMap.GetFullyQualifiedName(this._attribute2.Column.Name );
			}
			else //�������ķ�ʽ����
			{
				if (attrValue != System.DBNull.Value )
				{
				
					switch (_atrribute.SqlValueStringType)
					{
						case SqlValueTypes.PrototypeString:
							if(type==SelectionTypes.Match || type==SelectionTypes.MatchPrefix)
								s = s + "'" +attrValue.ToString ()+"'";
							else
								s = s + attrValue.ToString ();
					
							break;
						case SqlValueTypes.SimpleQuotesString:
							s = s + "'" + attrValue.ToString () + "'";
							break;
						case SqlValueTypes.String:
							s = s + "'" + attrValue.ToString ().Replace ("'","''") + "'";
							break;
						case SqlValueTypes.BoolToInterger:
						case SqlValueTypes.BoolToString:
							s=s+"'"+Convert.ToInt32(attrValue).ToString()+"'";
							break;
						case SqlValueTypes.AccessDateString:
							s = s + "#" + attrValue.ToString ().Replace ("'","''") + "#";
							break;
						case SqlValueTypes.OracleDate:
							s=s + "to_date('"+attrValue.ToString ().Replace ("'","''")+"','yyyy-mm-dd hh24:mi:ss')";
							break;
						case SqlValueTypes.NotSupport:
							string err = "��֧��������" + this._atrribute.Name + "��������������������������";
							throw new PlException (err,ErrorTypes.PesistentError);
						default:
							break;
					}
				}
				
			}
			return s;
		}

		//ΪInCrtieria �����ַ���
		private string StringOfInCrtieria (object[] list)
		{
			string s = "";
			int i = 0;
			switch (_atrribute.SqlValueStringType)
			{
				case SqlValueTypes.PrototypeString:
					for (; i < list.Length;i ++)
					{
						if (i == 0)
						{
							s = s + list[i].ToString ();
						}
						else
						{
							s = s + "," +list [i].ToString ();
						}
					}
					break;
				case SqlValueTypes.SimpleQuotesString:
					for (; i < list.Length;i ++)
					{
						if (i == 0)
						{
							s = s + "'" + list[i].ToString () + "'";
						}
						else
						{
							s = s +",'" + list[i].ToString () + "'";
						}
					}
					break;
				case SqlValueTypes.String:
					for(;i < list.Length;i ++)
					{
						if (i == 0)
						{
							s = s + "'" + list[i].ToString ().Replace ("'","''") + "'";
						}
						else
						{
							s = s + ",'" + list[i].ToString ().Replace ("'","''") + "'";
						}
					}
					break;
				case SqlValueTypes.NotSupport:
					throw new PlException ("��֧��������" + this._atrribute.Name + "��������������������������",
						ErrorTypes.PesistentError);
			}
			return s;
		}

		//Return type of SelectionCriteria
		public SelectionTypes Type
		{
			get{return this.type;}
		}

		public string AttributeName
		{
			get{return this.attrName;}
		}
		
		public object AttributeValue
		{
			get{return this.attrValue;}
		}
		
		public AttributeMap Attribute
		{
			set {this._atrribute = value;}
		}

	}
}
