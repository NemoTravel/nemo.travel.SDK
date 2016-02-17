using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ODPairs", ItemName = "ODPair")]
	public class FlightPairList : List<FlightPair>
	{
	}
}