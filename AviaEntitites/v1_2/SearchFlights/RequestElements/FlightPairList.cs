using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ODPairs_1_2", ItemName = "ODPair")]
	public class FlightPairList : List<FlightPair>
	{
	}
}