using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightSegments", ItemName = "FlightSegment")]
	public class FlightSegmentList : List<FlightSegment>
	{
	}
}