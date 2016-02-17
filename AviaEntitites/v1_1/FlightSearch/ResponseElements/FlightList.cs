using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Flights", ItemName = "Flight")]
	public class FlightList : List<Flight>
	{
	}
}
