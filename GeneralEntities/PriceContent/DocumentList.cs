using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(ItemName = "Document", Namespace = "http://nemo-ibe.com/Avia")]
	public class DocumentList : List<string>
	{
		public DocumentList() : base() { }

		public DocumentList(IEnumerable<string> collection) : base(collection) { }
	}
}
