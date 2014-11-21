using System;

namespace PersistenceLayer
{
	/// <summary>
	///		This class contains information about association map.
	/// </summary>
	sealed class Association
	{
		private CardinalityTypes cardinality = CardinalityTypes.None;
		private bool saveAutomatic=false;
		private bool deleteAutomatic=false;
		private bool retrieveAutomaitic=false;

		private string toClass =".";
		private string fromClass = ".";

		private string from=".";
		private string to=".";
		private string associationTo=".";

		//Constructor 1
		internal Association()
		{
		}

		/*��������*/
		//��������(1-1,1-N)
		public CardinalityTypes Cardinality
		{
			get{return this.cardinality;}
			set{this.cardinality=value;}
		}
		
		//�������Ƿ��Զ�����
		public bool SaveAutomatic
		{
			get{return this.saveAutomatic;}
			set{this.saveAutomatic=value;}
		}

		//�������Ƿ��Զ�ɾ��
		public bool DeleteAutomatic
		{
			get{return this.deleteAutomatic;}
			set{this.deleteAutomatic=value;}
		}

		//�������Ƿ��Զ���ȡ
		public bool RetrieveAutomatic
		{
			get{return this.retrieveAutomaitic;}
			set{this.retrieveAutomaitic=value;}
		}

		//������ʵ����
		public string ToClass
		{
			get{return this.toClass;}
			set{this.toClass=value;}
		}
		
		//������ʵ����
		public string FromClass
		{
			get{return this.fromClass;}
			set{this.fromClass=value;}
		}

		public string FromAttribute
		{
			get{return this.from;}
			set{this.from=value;}
		}

		public string ToAttribute
		{
			get{return this.to;}
			set{this.to=value;}
		}

		public string Target
		{
			get{return this.associationTo;}
			set{this.associationTo=value;}
		}
	}
	
}
