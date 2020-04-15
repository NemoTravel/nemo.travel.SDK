using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Traveller
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Traveller")]
	public class TravellerList : List<TravellerInformation>
	{
		public TravellerList() { }

		public TravellerList(IEnumerable<TravellerInformation> collection) : base(collection) { }
	}
}