using System;
using System.Xml;
using System.Collections;
using System.Data.OleDb;
using System.Data;

namespace PersistenceLayer
{
	/// <summary>
	/// XmlConfigLoader ��ժҪ˵����
	/// </summary>
	class XmlConfigLoader:IConfigLoader
	{
		private string thisNameSpace = "";			//ʵ������ֿռ�
		private string databaseXmlFile;				//���ݿ���Ϣ�ļ�

		private Hashtable classMaps;				//Class Hash��
		private Hashtable databaseMaps;				//���ݿ�Hash��
		private IDictionary databaseCollection;
		private ArrayList classMapFiles;
		private static XmlConfigLoader xmlConfigLoader;
		
		private XmlConfigLoader()
		{
			//XmlFile=fileName;
			//this.databaseXmlFile=databaseMapFile;

			classMaps=new Hashtable();
			databaseMaps=new Hashtable();
			databaseCollection=new Hashtable();
			this.classMapFiles = new ArrayList();

			this.thisNameSpace = this.ToString ().Substring (0,this.ToString ().LastIndexOf('.')+1);
		}

		public static XmlConfigLoader Instance()
		{
			if(xmlConfigLoader==null)
				xmlConfigLoader=new XmlConfigLoader();
			return xmlConfigLoader;

		}
		
		public Hashtable ClassMaps
		{
			get{return classMaps;}
		}
		public Hashtable DatabaseMaps
		{
			get{return databaseMaps;}
		}
		public IDictionary DatabasePool
		{
			get{return databaseCollection;}
		}
		
		//��ָ���ļ��ж�ȡ����ӳ����Ϣ
		public void LoadConfig(string databaseMapFile)
		{
			this.databaseXmlFile=databaseMapFile;
			this.LoadDatabaseInformation();
			for(int i=0;i<this.classMapFiles.Count;i++)
			{
				string file=classMapFiles[i].ToString().Trim();
				if (file.IndexOf(':')<0)
				{
					file = databaseXmlFile.Substring (0,databaseXmlFile.LastIndexOf ('\\')+1) + file;
				}
				if(file=="")
				{
					throw new PlException("ClassMapFile·������Ϊ�գ�");
				}
				else
				{
					this.LoadClassMapInformation(file);
				}
			}
		}
		
		//��ָ���ļ��ж�ȡ��ӳ����Ϣ
		internal void LoadClassMapInformation(string xmlFile)
		{
			XmlDocument oXmlDocument=new XmlDocument();
			//string file=this.XmlFile;
			string file=xmlFile;
			try
			{
				oXmlDocument.Load(file);
				XmlNodeReader oXmlReader=new XmlNodeReader(oXmlDocument);
				while(oXmlReader.Read())
				{
					if (oXmlReader.NodeType!=XmlNodeType.Element) continue;
					ClassMap cls;
					//�������ݿ�ӳ��Node
					switch (oXmlReader.Name.ToLower())
					{
						case "class":
							cls=GetClassMap(oXmlReader);
							if (cls!=null && (!classMaps.Contains(cls.Name))) classMaps.Add(cls.Name,cls);
							break;
							//���ǹ�����ϵ
						case "association":
							Association a = GetAssociation (oXmlReader); 
							cls = (ClassMap)this.classMaps [a.FromClass];
							cls.AddAssociation (a);
							break;
					}
				}
			}
			catch(PlException ple)
			{
				throw ple;
			}
			catch(Exception e)
			{
				string s="��ȡ��ӳ���ļ�"+file+"��������,��ȷ������ļ�·���͸�ʽ!";
				s=s+e.Message;
				throw new PlException(s,ErrorTypes.XmlError);
			}		
		}

		
		//��ָ���ļ���ȡ���ݿ�ӳ����Ϣ�����Ӳ���
		/// <summary>
		/// ��XML�ļ��л�ȡ���ݿ�������Ϣ
		/// 
		/// </summary>
		private void LoadDatabaseInformation()
		{
			XmlDocument oXmlDocument=new XmlDocument();
			string file=this.databaseXmlFile;
			try
			{
				oXmlDocument.Load(file);
				XmlNodeReader oXmlReader=new XmlNodeReader(oXmlDocument);
				while(oXmlReader.Read())
				{
					if (oXmlReader.NodeType!=XmlNodeType.Element) continue;
					//�������ݿ�ӳ��Node
					if (oXmlReader.Name.ToLower()=="database")
					{
						//�������ݿ���,����һ��raletionDatabase����
						RelationalDatabase rdb=GetRelationalDatabase(oXmlReader);
						if (rdb!=null)
						{
							if(databaseCollection.Contains(rdb.Name))
								databaseCollection.Remove(rdb.Name);
							databaseCollection.Add(rdb.Name,rdb);
						}
					}
				}
			}
			catch(PlException ple)
			{
				throw ple;
			}
			catch(Exception e)
			{
				string s="��ȡ���ݿ�ӳ���ļ�"+file+"ʱ��������,��ȷ������ļ�·�����ļ���ʽ��";
				s=s+e.Message;
				throw new PlException(s,ErrorTypes.XmlError);
				//throw e;
			}
		}
		//Xml�ļ�������
		private void AddMap(XmlNodeReader oReader)
		{
			if (oReader.NodeType!=XmlNodeType.Element) return;
			
			switch (oReader.Name.ToLower())
			{
				case "class":					//�������ӳ����
					ClassMap cls=GetClassMap(oReader);
					if (cls!=null) classMaps.Add(cls.Name,cls);
					break;
				case "database":
					RelationalDatabase rdb=GetRelationalDatabase(oReader);
					if (rdb!=null) databaseCollection.Add(rdb.Name,rdb);
					break;
				default:
					break;
			}
		}

		//��Xml Node���(Name=class)�õ���ӦClassMap
		private ClassMap GetClassMap(XmlNodeReader node)
		{
			string className=node.GetAttribute("name");										//����
			string tableName=node.GetAttribute("table");									//����
			string databaseName=node.GetAttribute("database");								//���ݿ���
			string superClassName=node.GetAttribute("superclass");							//������
			//string timeStamp = node.GetAttribute ("timeStamp");							//ʱ���
			
			string IsSaveToMemory=node.GetAttribute("IsSaveToMemory");
			if(IsSaveToMemory==null)
				IsSaveToMemory="false";

			int c = 0;
			string err;

			ClassMap clsMap=null;
			if ((className!=null) &&(databaseName!=null)&&(tableName!=null))
			{
				RelationalDatabase r=(RelationalDatabase)this.DatabasePool[databaseName];
				if ( r == null)
				{
					err = "��Ϊ��" + databaseName + "�����ݿ�ӳ����Ϣδ�ҵ���";
					throw new PlException (err,ErrorTypes.XmlError);
				}
				clsMap=new ClassMap(className,r);
				//��XML��ȡ�Ƿ񱣴浽�ڴ�ֵ
				clsMap.IsSaveToMemory=IsSaveToMemory.ToLower()=="true"?true:false;

				if (superClassName!=null)
				{
					clsMap.SuperClass=(ClassMap)classMaps[superClassName];
					if (clsMap.SuperClass == null)
					{
						err = "��superclass������ " + superClassName + "ǰ������Ը���ӳ�䣡";
						throw new PlException (err,ErrorTypes.XmlError);
					}
					clsMap.SelfClassAttributes = new ArrayList ();
				}
				else
				{
					//�������û�и��࣬���SelfClassAttributesָ��AttributesMapToTable
					clsMap.SelfClassAttributes = clsMap.AttributesMapToTable;
				}
				//����һ��DatabaseMap���󣬲�����databaseMaps
				//�����Ѵ�����ֱ������
				if (!databaseMaps.ContainsKey(databaseName))
				{
					err = "��ӳ���ࣺ" + className + "ʱ����Ϊ��" + databaseName + "�����ݿ�ӳ����Ϣ�Ҳ�����";
					throw new PlException (err,ErrorTypes.XmlError);
				}
				//
				TableMap tblMap=new TableMap(tableName,(DatabaseMap)databaseMaps[databaseName]);

				int clsDep=node.Depth;
				while(node.Read()&&node.Depth>clsDep)
				{
					if ((node.NodeType==XmlNodeType.Element)&&(node.Name=="attribute"))
					{
						//����Node��Element������ �� ����������attribute
						AttributeMap attrMap = GetAttributeMap(node,clsMap,tblMap,c);
						if (attrMap!=null) 
						{
							clsMap.AddAttributeMap(attrMap);
						}
						c++;
					}
				}
			}
			else
			{
				err = "ClassMap ȱ��className,databaseName,tableName ��Щ��Ҫ���ԣ�";
				throw new PlException (err,ErrorTypes.XmlError);
			}
			//ȱ������
			if (clsMap.Table.PrimaryKeyIndex < 0)
			{
				err = "�� " + clsMap.Table.Name + " δ����������";
				throw new PlException (err,ErrorTypes.XmlError);
			}
			return clsMap;
		}

		private AttributeMap GetAttributeMap(XmlReader reader,ClassMap clsMap,TableMap tblMap,int colIndex)
		{
			string attrName=reader.GetAttribute("name");				//��������
			string attrColumn=reader.GetAttribute("column");			//���Զ�Ӧ����
			string attrKey=reader.GetAttribute("key");					//������
			string attrReference=reader.GetAttribute("reference");		//���ø�������
			string dataType=reader.GetAttribute("type");				//��������
			string autoIncrement=reader.GetAttribute("increment");		//�Ƿ��Զ�����
			string timestamp = reader.GetAttribute ("timestamp");		//ʱ���
			string autoValue = reader.GetAttribute ("auto");			//�Ƿ��Զ�ֵ

			AttributeMap attrMap=null;
			
			if (attrName!=null)
			{
				ColumnMap colMap=null;
				//����һ��AttributeMap
				attrMap=new AttributeMap(attrName);
				if (attrColumn!=null)
				{
					colMap=new ColumnMap(attrColumn,tblMap);

					if (attrKey!=null)
					{
						//���ü�����
						if (attrKey.ToUpper()=="PRIMARY")
						{
							colMap.KeyType=ColumnKeyTypes.PrimaryKey;
						}
						else if (attrKey.ToUpper()=="FOREIGN")
						{
							colMap.KeyType=ColumnKeyTypes.ForeignKey;
						}
					}
					if(dataType==null)
					{
						string s="����ȷ����"+clsMap.GetFullyQualifiedName(colMap.Name)+"���������ͣ�";
						throw new PlException(s,ErrorTypes.XmlError);
					}
					//ȷ�������е���������
					//Xml��������������ΪOleDbType�е�ö������
					//����ӳ�䵽 DbType
					switch (dataType.ToLower())
					{
						case "boolean":
							colMap.Type=DbType.Boolean;
							attrMap.SqlValueStringType = clsMap.RelationalDatabase.SqlValueType (DbType.Boolean);
							break;
							//Map to Int64
						case "bigint":
							colMap.Type=DbType.Int64;
							break;
							//Map to Binary
						case "binary":
							colMap.Type = DbType.Binary;
							attrMap.SqlValueStringType = SqlValueTypes.NotSupport;
							break;
							//Map to Decimal
						case "currency":
							colMap.Type=DbType.Currency;
							break;
							//Map to DateTime
						case "date":
							//��Access�����ݿ������⴦��
							if (clsMap.RelationalDatabase.Vendor == MsAccess.VENDOR_NAME)
							{
								colMap.Type=DbType.Object;
								attrMap.SqlValueStringType = SqlValueTypes.AccessDateString;
							}
							else if(clsMap.RelationalDatabase.Vendor==DatabaseVendor.Oracle) //�����oracle�Ļ�����������ʹ��to_dateת��
							{
								colMap.Type=DbType.DateTime;
								attrMap.SqlValueStringType = SqlValueTypes.OracleDate;
							}
							else
							{
								colMap.Type=DbType.DateTime;
								attrMap.SqlValueStringType = SqlValueTypes.SimpleQuotesString;
							}
							break;
							//Mapt to Date
						case "dbdate":
							colMap.Type = DbType.Date;
							attrMap.SqlValueStringType = SqlValueTypes.SimpleQuotesString;
							break;
							//Map to Decimal
						case "decimal":
							colMap.Type=DbType.Decimal;
							break;
							//Map to Double
						case "double":
							colMap.Type=DbType.Double;
							break;
							//Map to Guid
						case "guid":
							colMap.Type=DbType.Guid;
							attrMap.SqlValueStringType = SqlValueTypes.SimpleQuotesString;
							break;
							//Map to Object
						case "object":
							colMap.Type = DbType.Object;
							attrMap.SqlValueStringType = SqlValueTypes.NotSupport;
							break;
							//Map to Single
						case "single":
							colMap.Type = DbType.Single;
							break;
							//Map to Int16
						case "smallint":
							colMap.Type=DbType.Int16;
							break;
							//Map to SBtype
						case "tinyint":
							colMap.Type = DbType.Byte;
							break;
							//Map to Int32
						case "integer":
							colMap.Type=DbType.Int32;
							break;
							//Map to String
						case "varchar":
						case "string":
							colMap.Type=DbType.String;
							attrMap.SqlValueStringType = SqlValueTypes.String;
							break;
						
							
						default:
							throw new PlException("Ŀǰ�Բ�֧�ֵ��������ͣ�",ErrorTypes.XmlError);
					}
					//���в����Զ�����
					if(autoIncrement!=null && autoIncrement.ToLower()=="true")
					{
						colMap.IsAutoValue=true;
						tblMap.AutoIdentityIndex = colIndex;
						clsMap.AutoIdentityAttribute = attrName;
					}

					//�ǲ���timestamp
					if (timestamp != null && timestamp.ToLower()=="true")
					{
						tblMap.TimestampColumn = attrColumn;
						if(clsMap.RelationalDatabase.Vendor==DatabaseVendor.MySql)
							tblMap.TimestampParameter = "?" + tblMap.TimestampColumn ;
						else
							tblMap.TimestampParameter = "@" + tblMap.TimestampColumn ;
						//tblMap.TimestampParameter = "@" + tblMap.TimestampColumn ;
						clsMap.TimestampAttribute = attrMap;
						colMap.IsAutoValue = true ;
					}

					//�ǲ����Զ�ֵ
					if (autoValue !=null)
					{
						colMap.IsAutoValue = true;
					}
				}// end of if (column!=null)
				
				attrMap.Column=colMap;
				
				if ((attrReference!=null)&&(clsMap.SuperClass!=null))
				{
					//�����������Ը��࣬������Reference����ָ�����AttributeMap
					AttributeMap r=clsMap.SuperClass.GetAttributeMap(attrReference,true);
					if (r!=null) attrMap.Reference=r;
				}

			}
			return attrMap;
		}
	
		//��Xml Element(association)�õ���Ӧ Association
		private Association GetAssociation (XmlNodeReader node)
		{
			int dep = node.Depth;
			Association a = new Association ();
			//ȡ�ù�����
			string associationName = node.GetAttribute ("name").Trim ();
			if (associationName == null||associationName == "")
			{
				throw new PlException ("Association������󣺹���δ���� name��");
			}
			
			while( node.Read () && node.Depth > dep)
			{
				//����Node��Element����
				if (node.NodeType==XmlNodeType.Element)
				{
					string elementName = node.Name;
					switch (elementName)
					{
						case "fromClass":
							a.FromClass = node.ReadString ().Trim ();
							//δ�ҵ���Ϊ��FromClass�����Map��Ϣ
							if (classMaps[a.FromClass] == null)
							{
								string err = "����" + associationName + "��FromClass:" + 
									a.FromClass + "δ�ҵ�Map��Ϣ��";
								throw new PlException (err);
							}
							break;
						case "toClass":
							a.ToClass = node.ReadString ().Trim ();
							//δ�ҵ���Ϊ��ToClass�����Map��Ϣ
							if (classMaps[a.ToClass] == null)
							{
								string err = "����" + associationName + "��ToClass:" + 
									a.ToClass + "δ�ҵ�Map��Ϣ��";
								throw new PlException (err);
							}
							break;
						case "cardinality":
							string t = node.ReadString ().Trim ();
							if (t == "oneToMany")
							{
								a.Cardinality = CardinalityTypes.OneToMany;
							}
							else
							{
								if (t == "oneToOne")
									a.Cardinality = CardinalityTypes.OneToOne;
								else
									throw new PlException(associationName +"�в���ʶ���Cardinality���壡");
							}
							break;							 
						case "target":
							a.Target = node.ReadString ().Trim ();
							break;
						case "retrieveAutomatic":
							if (node.ReadString ().Trim () == "true")
							{
								a.RetrieveAutomatic = true;
							}
							break;
						case "deleteAutomatic":
							if (node.ReadString ().Trim () == "true")
							{
								a.DeleteAutomatic = true;
							}
							break;
						case "saveAutomatic":
							if (node.ReadString ().Trim () == "true")
							{
								a.SaveAutomatic = true;
							}
							break;
						case "fromAttribute":
							a.FromAttribute = node.ReadString ().Trim ();
							break;
						case "toAttribute":
							a.ToAttribute = node.ReadString ().Trim ();
							break;
						default:
							throw new PlException ("associationName" +"�в���ʶ����:" + elementName);
					}
				}
			}
			if (a.Cardinality == CardinalityTypes.None)
			{
				throw new PlException (associationName +"������cardinality����δ���ã�");
			}
			return a;
		}
	
		//����Node�������һ����Ӧ��RelationalDatabase����
		/// <summary>
		/// ��һ�����ݿ����ýڵ�,��ȡһ�����ݿ�����
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		private RelationalDatabase GetRelationalDatabase(XmlNodeReader node)
		{
			string dbName=node.GetAttribute("name");
			string dbType = node.GetAttribute ("type");
			
			RelationalDatabase rdb=null;
			if ((dbName!=null))								//Mark!!!!!!	
			{
				if (dbType == null || dbType =="")
				{
					throw new PlException ("��֧�ֵ����ݿ����ͣ�",ErrorTypes.XmlError);
					//rdb=new OtherDatabase ();				
				}
				else
				{
					string dbClassName = thisNameSpace + dbType;
					try
					{
						//�������ݿ����������.������Ӧ�����ݿ����.
						//��:MsSqlServer,���Զ����ɴ�ʵ��
						rdb = (RelationalDatabase)this.GetType().Assembly.CreateInstance (dbClassName);
						if (rdb == null) throw new Exception();
					}
					catch
					{
						string error = "��������Ϊ��" + dbClassName + "�����ݿ����";
						throw new PlException (error,ErrorTypes.XmlError);
					}
				}
				rdb.Name = dbName;
				if(databaseMaps.Contains(dbName))
					databaseMaps.Remove(dbName);
				databaseMaps.Add(dbName,new DatabaseMap(dbName));
				int i=node.Depth;

				string pName,pValue,connectionString = "";
				while(node.Read()&&node.Depth>i)
				{
					//����Node��Element������ �� ����������parameter
					if((node.NodeType==XmlNodeType.Element)&&(node.Name=="parameter"))
					{
						pName = node.GetAttribute("name");
						pValue = node.GetAttribute("value");

						//tintown add 2005-3-10 ֧��access���ݿ���Ե�ַ ,laser add 2005-4-15 ���������·�����޸�
						if(pValue.EndsWith("mdb") && pValue.IndexOf(':')<0&&pValue.IndexOf('\\')<0)
							pValue=databaseXmlFile.Substring (0,databaseXmlFile.LastIndexOf ('\\')+1) +pValue;

						if((pName != null)&&( pValue!=null)) 
						{
							connectionString += pName + "=" + pValue + ";";
						}
					}
					else if(node.Name.ToLower()=="classmapfile")
					{	
						if(node.GetAttribute("path")!=null)
						{
							this.classMapFiles.Add(node.GetAttribute("path"));
						}
					}
				}
				rdb.Initialize (connectionString);
				//Setting.Instance().SetConnectionString(rdb.Name,rdb.ConnectionString);
			}
			return rdb;
		}
	}
}
