using AviaEntities.v1_1.FlightSearch.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AirItineraries", ItemName = "AirItinerary")]
	public class AirItineraryList : List<AirItinerary>
	{
	}
}