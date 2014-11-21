using System;
using System.Data;
//using System.Data.OleDb;

namespace PersistenceLayer
{
	/// <summary>
	/// InsertCommander��װ����Insert Command�Ĺ���
	/// </summary>
	class InsertCommander:SqlCommander
	{
		public InsertCommander(ClassMap cm):base(cm)
		{
			this.GetSqlInsert();
		}

		//���� ʵ����� ��Ӧ��InsertCommand
		public override IDbCommand BuildForObject(EntityObject obj)
		{
			AttributeMap attrMap;
			IDbCommand cmd = this.clsMap.RelationalDatabase.GetCommand ();
			object tmp;

			cmd.CommandText=this.SqlString; 
			int size = ThisClassMap.GetSize ();
			for(int i=0;i< size;i++)
			{
				attrMap=ThisClassMap.GetAttributeMap(i);
				if (attrMap.Column.IsAutoValue) continue;
				IDataParameter p = cmd.CreateParameter();
				//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();				//����	
				if(this.clsMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
					p.ParameterName="?"+attrMap.Name;
				else
                    p.ParameterName = "@" + attrMap.Name;
				p.DbType=attrMap.Column.Type;										//������
				
				tmp=obj.GetAttributeValue(attrMap.Name);							//��ֵ
				if (tmp==null || (tmp is DateTime && (DateTime)tmp==DateTime.MinValue))
				{
					p.Value=DBNull.Value;
				}
				else
				{
					p.Value=tmp;
				}

				//mif (p is OleDbParameter)
				cmd.Parameters.Add (p);
			}

			//tintown added at 2005-3-22 ����timestamp��ֵ
			if(ThisClassMap.TimestampAttribute!=null)
			{
				attrMap=ThisClassMap.TimestampAttribute;
				IDataParameter p= cmd.CreateParameter();
				//p.SourceColumn=attrMap.Column.GetFullyQualifiedName();					//����												//����
				if(this.clsMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
					p.ParameterName="?"+attrMap.Name;
				else
					p.ParameterName = "@" + attrMap.Name;
				p.DbType=attrMap.Column.Type;										//������				
				p.Value=DateTime.Now.Ticks;	   			//��timestamp��now��ticks����һ������
				cmd.Parameters.Add (p);
			}

			return cmd;			
		}

		//����Sql���ǰ����
		private void GetSqlInsert()
		{
			this.AddSqlClause("INSERT INTO ");
			this.AddSqlClause(ThisClassMap.RelationalDatabase.QuotationMarksStart+ThisClassMap.GetAttributeMap(0).Column.Table.Name+ThisClassMap.RelationalDatabase.QuotationMarksEnd);
			this.AddSqlClause(" ");
			string sqlParas="";

			//Add clauses for all attributes
			AttributeMap am;
			bool isFirst=true;
			this.AddSqlClause("(");
			int size = ThisClassMap.GetSize ();
			for(int i=0;i< size;i++)
			{
				am=ThisClassMap.GetAttributeMap(i);
				if (am.Column.IsAutoValue)continue;
				
				if (isFirst)
				{
					this.AddSqlClause(clsMap.RelationalDatabase.GetQuotationColumn(am.Column.Name));
					//sqlParas="?";
					sqlParas = this.clsMap.RelationalDatabase.GetStringParameter(am.Name,i);
				}
				else
				{
					this.AddSqlClause(",");
					this.AddSqlClause(clsMap.RelationalDatabase.GetQuotationColumn(am.Column.Name));
					//sqlParas+=",?";
					sqlParas += "," + this.clsMap.RelationalDatabase.GetStringParameter(am.Name,i);

				}
				isFirst=false;
 			}

			//tintown added at 2005 -3-22 ��Ӷ�timestamp�����
			if(ThisClassMap.TimestampAttribute!=null)
			{
				if (!isFirst)
				{
					this.AddSqlClause(",");
					sqlParas+=",";
				}
				this.AddSqlClause(clsMap.RelationalDatabase.GetQuotationColumn(ThisClassMap.TimestampAttribute.Column.Name));
				//sqlParas+=",?";
				sqlParas +=this.clsMap.RelationalDatabase.GetStringParameter(ThisClassMap.TimestampAttribute.Name,size);
			}


			this.AddSqlClause(")");
			//Add clause "VALUES" to the insertStatement
			this.AddSqlClause (" VALUES (");
			this.AddSqlClause(sqlParas);
			this.AddSqlClause(")");
		}

		
	}


}
