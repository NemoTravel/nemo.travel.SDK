using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Avia
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "FlightSegment")]
	public class FlightSegmentList : List<FlightSegment>
	{
	}
}