using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.BookContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Action")]
	public class PNRPossibleActionList : List<PNRPossibleAction>
	{
		public PNRPossibleActionList()
		{ }

		public PNRPossibleActionList(List<PNRPossibleAction> list)
			: base(list)
		{ }
	}
}