using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список сгруппированных сегментов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "OrderedFlightSegments", ItemName = "FlightSegment")]
	public class FlightSegmentBindingList : List<FlightSegmentBinding>
	{
	}
}