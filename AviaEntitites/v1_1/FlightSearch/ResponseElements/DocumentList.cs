using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[CollectionDataContract(ItemName = "Document", Namespace = "http://nemo-ibe.com/Avia")]
	public class DocumentList : List<string>
	{
		public DocumentList() : base() { }

		public DocumentList(IEnumerable<string> collection) : base(collection) { }
	}
}
