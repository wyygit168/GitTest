using System;

namespace PersistenceLayer
{
	/// <summary>
	/// OrderEntry ��ժҪ˵����
	/// </summary>
	struct OrderEntry
	{
		public string AttributeName;
		public bool   IsAscend;

		public OrderEntry(string attrName,bool isAsc)
		{
			AttributeName=attrName;
			IsAscend=isAsc;
		}
	}
}
