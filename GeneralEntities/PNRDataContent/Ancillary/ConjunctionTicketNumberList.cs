using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Number")]
	public class ConjunctionTicketNumberList : List<string>
	{
		public ConjunctionTicketNumberList()
		{ }

		public ConjunctionTicketNumberList(IEnumerable<string> arg)
			: base(arg)
		{ }
	}
}