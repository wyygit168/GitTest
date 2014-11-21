using System;
using System.Data;
//using System.Data.OleDb;

namespace PersistenceLayer
{
	/// <summary>
	/// DeleteCommander ��ժҪ˵����
	/// </summary>
	class DeleteCommander:SqlCommander
	{
		private string _deleteClause;

		public DeleteCommander(ClassMap cm):base(cm)
		{
			this.GetSqlDelete();
		}
		
		//���� ʵ����� ��Ӧ��DeleteCommand
		public override IDbCommand BuildForObject(EntityObject obj)
		{
			AttributeMap attrMap;
			IDbCommand cmd = clsMap.RelationalDatabase.GetCommand ();
		
			cmd.CommandText=this.SqlString+this.partForObject;
			for(int i=0;i<this.ThisClassMap.GetKeySize();i++)
			{
				attrMap=this.ThisClassMap.GetKeyAttributeMap(i);
				//�����Ƿ�Primary Key
				if (attrMap.Column.KeyType==ColumnKeyTypes.PrimaryKey)
				{
					IDataParameter p = cmd.CreateParameter ();
					//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����
					p.DbType=attrMap.Column.Type;											//������
					p.Value=obj.GetAttributeValue(attrMap.Name);							//��ֵ
					if(this.ThisClassMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
						p.ParameterName = "?" + attrMap.Name;
					else
						p.ParameterName = "@" + attrMap.Name;
					
					cmd.Parameters.Add (p);
				}
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
				p.DbType=attrMap.Column.Type;										//������				
				p.Value=obj.GetAttributeValue(attrMap.Name);							//��ֵ
				cmd.Parameters.Add (p);
			}

			return cmd;
		}
		
		//����Delete Sql���
		private void GetSqlDelete()
		{
			//Add 'DELETE FROM' clause to the select statement
			this.AddSqlClause("DELETE FROM ");
			this.AddSqlClause(ThisClassMap.RelationalDatabase.QuotationMarksStart+ ThisClassMap.GetAttributeMap(0).Column.Table.Name+ThisClassMap.RelationalDatabase.QuotationMarksEnd);
			//Add 'WHERE key= "some value"' to the select statement

			this._deleteClause=this.sql;

			this.AddSqlClause(" WHERE 1=1 ");
			AttributeMap attrMap;
			ClassMap thisClassMap=this.ThisClassMap;

            for(int i=0;i<thisClassMap.GetKeySize();i++)
			{
				attrMap=thisClassMap.GetKeyAttributeMap(i);
				//�����Ƿ�Primary Key
				if (attrMap.Column.KeyType==ColumnKeyTypes.PrimaryKey)
				{
					this.partForObject+=" AND "+this.clsMap.GetFullyQualifiedName(attrMap.Column.Name)+"="+
						this.clsMap.RelationalDatabase.GetStringParameter (attrMap.Name,i);
				}
			}

			//tintown add by 2005-3-21 ���timestamp����
			if(ThisClassMap.TimestampAttribute!=null)
			{

				this.AddSqlClause(" AND "+this.clsMap.GetFullyQualifiedName(ThisClassMap.TimestampAttribute.Column.Name)+"=");
				this.AddSqlClause(ThisClassMap.RelationalDatabase.GetStringParameter(ThisClassMap.TimestampAttribute.Column.Name,ThisClassMap.GetKeySize()));
			}
		}


		public string DeleteClause 
		{
			get {return this._deleteClause;}
		}
	
	
	}
}
