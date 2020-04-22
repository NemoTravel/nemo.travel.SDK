using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	[CollectionDataContract(Namespace = "http://nemo.travel/STL", ItemName = "RelatedTicket")]
	public class RelatedTicketsList : HashSet<string>
	{
		public RelatedTicketsList()
		{ }

		public RelatedTicketsList(HashSet<string> hashSet)
			: base(hashSet)
		{ }
	}
}