using System;
using System.Data;
//using System.Data.OleDb;

namespace PersistenceLayer
{
	/// <summary>
	/// UpdateCommander ��ժҪ˵����
	/// </summary>
	class UpdateCommander:SqlCommander
	{
		public UpdateCommander(ClassMap cm):base(cm)
		{
			this.GetSqlUpdate();
		}

		//���� ʵ����� ��Ӧ��UpdateCommand
		public override IDbCommand BuildForObject(EntityObject obj)
		{
			AttributeMap attrMap;
			IDbCommand cmd = this.clsMap.RelationalDatabase.GetCommand ();
			object tmp;

			cmd.CommandText=this.SqlString; 
			int size = ThisClassMap.GetSize();
			for(int i=0;i< size;i++)
			{
				attrMap=ThisClassMap.GetAttributeMap(i);
				if (attrMap.Column.KeyType==ColumnKeyTypes.PrimaryKey) continue;
				//tintown add at 2004-09-23
				//�������Ϊ�Զ�����,��������update���ʱ����
				if (attrMap.Column.IsAutoValue==true) continue;
				//tintown add end
				IDataParameter p = cmd.CreateParameter ();
				//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����
				if(this.ThisClassMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
					p.ParameterName = "?" + attrMap.Name;
				else
					p.ParameterName = "@" + attrMap.Name;
				
				p.DbType=attrMap.Column.Type;										//������
				tmp=obj.GetAttributeValue(attrMap.Name);								//��ֵ
				if (tmp==null || (tmp is DateTime && (DateTime)tmp==DateTime.MinValue))
				{
					p.Value=DBNull.Value;
				}
				else
				{
					p.Value=tmp;
				}				
				cmd.Parameters.Add (p);
			}

			//tintown added at 2005-3-22 ����timestamp��ֵ
			if(ThisClassMap.TimestampAttribute!=null)
			{
				attrMap=ThisClassMap.TimestampAttribute;
				IDataParameter p= cmd.CreateParameter();
				//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����
				if(this.ThisClassMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
					p.ParameterName = "?Update" + attrMap.Name;
				else
					p.ParameterName = "@Update" + attrMap.Name;
				//p.ParameterName = "@Update" + attrMap.Name;
				p.DbType=attrMap.Column.Type;										//������				
				p.Value=DateTime.Now.Ticks;	   			//��timestamp��now��ticks����һ������
				cmd.Parameters.Add (p);
			}

			for(int i=0;i<ThisClassMap.GetKeySize();i++)
			{
				attrMap=ThisClassMap.GetKeyAttributeMap(i);
				IDataParameter p= cmd.CreateParameter();
				//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����
				if(this.ThisClassMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
					p.ParameterName = "?" + attrMap.Name;
				else
					p.ParameterName = "@" + attrMap.Name;
				//p.ParameterName = "@" + attrMap.Name;
				p.DbType=attrMap.Column.Type;										//������				
				p.Value=obj.GetAttributeValue(attrMap.Name);							//��ֵ
				cmd.Parameters.Add (p);
			}


			//tintown add by 2005-3-21 ���timestamp����
			if(ThisClassMap.TimestampAttribute!=null)
			{
				attrMap=ThisClassMap.TimestampAttribute;
				IDataParameter p= cmd.CreateParameter();
				//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����
				if(this.ThisClassMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
					p.ParameterName = "?" + attrMap.Name;
				else
					p.ParameterName = "@" + attrMap.Name;
				//p.ParameterName = "@" + attrMap.Name;
				p.DbType=attrMap.Column.Type;										//������				
				p.Value=obj.GetAttributeValue(attrMap.Name);							//��ֵ
				cmd.Parameters.Add (p);
			}
			return cmd;			
		}

		//����Update Sql���
		private void GetSqlUpdate()
		{
			this.AddSqlClause("UPDATE ");
			this.AddSqlClause(ThisClassMap.RelationalDatabase.QuotationMarksStart+ThisClassMap.GetAttributeMap(0).Column.Table.Name+ThisClassMap.RelationalDatabase.QuotationMarksEnd);
			this.AddSqlClause(" ");
			//Add clauses for all attributes but key attributes
			this.AddSqlClause("SET ");
			AttributeMap attrMap;
			bool isFirst=true;
			for(int i=0;i<ThisClassMap.GetSize();i++)
			{
				attrMap=ThisClassMap.GetAttributeMap(i);
				if(attrMap.Column.KeyType==ColumnKeyTypes.PrimaryKey) continue;
				//add by tintown at 2004-09-23
				//�����Զ���������,������update
				if(attrMap.Column.IsAutoValue==true) continue;
				//add by tintown end
				if (isFirst)
				{
					//this.AddSqlClause(ThisClassMap.GetAttributeMap(i).Column.GetFullyQualifiedName()+"=?");
					this.AddSqlClause(clsMap.GetFullyQualifiedName(ThisClassMap.GetAttributeMap(i).Column.Name)+"=");
					this.AddSqlClause(ThisClassMap.RelationalDatabase.GetStringParameter (attrMap.Name,i));
					isFirst=false;
				}
				else
				{
					this.AddSqlClause(",");
					//this.AddSqlClause(ThisClassMap.GetAttributeMap(i).Column.GetFullyQualifiedName()+"=?");
					this.AddSqlClause(clsMap.GetFullyQualifiedName(ThisClassMap.GetAttributeMap(i).Column.Name)+"=");
					this.AddSqlClause(ThisClassMap.RelationalDatabase.GetStringParameter (attrMap.Name,i));
				}
				
			}
			
			//tintown added at 2005-3-22 SQL�������Ӹ���timestamp
			if(ThisClassMap.TimestampAttribute!=null)
			{
				this.AddSqlClause(",");
				this.AddSqlClause(clsMap.GetFullyQualifiedName(ThisClassMap.TimestampAttribute.Column.Name)+"=");
				this.AddSqlClause(ThisClassMap.RelationalDatabase.GetStringParameter("Update"+ThisClassMap.TimestampAttribute.Column.Name,ThisClassMap.GetSize()+1));
			}


			//Add clause "WHERE" to the insertStatement
			this.AddSqlClause(" WHERE 1=1 ");
			for(int i=0;i<ThisClassMap.GetKeySize();i++)
			{
				attrMap=ThisClassMap.GetKeyAttributeMap(i);
				//�����Ƿ�Primary Key
				if (attrMap.Column.KeyType==ColumnKeyTypes.PrimaryKey)
				{
					this.AddSqlClause(" AND "+clsMap.GetFullyQualifiedName(attrMap.Column.Name)+"=");
					this.AddSqlClause(clsMap.RelationalDatabase.GetStringParameter(attrMap.Name,ThisClassMap.GetSize()+i+1));
				}

				
			}

			//tintown add by 2005-3-21 ���timestamp����
			if(ThisClassMap.TimestampAttribute!=null)
			{

				this.AddSqlClause(" AND "+clsMap.GetFullyQualifiedName(ThisClassMap.TimestampAttribute.Column.Name)+"=");
				this.AddSqlClause(ThisClassMap.RelationalDatabase.GetStringParameter(ThisClassMap.TimestampAttribute.Column.Name,ThisClassMap.GetKeySize()+ThisClassMap.GetSize()+2));
			}
			
		}
	}
}
