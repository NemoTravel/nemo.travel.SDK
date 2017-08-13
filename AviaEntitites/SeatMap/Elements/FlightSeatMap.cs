using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Список карты мест для каждого из сегментов перелётов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "SeatMapSegments", ItemName = "SeatMapSegment")]
	public class FlightSeatMap : List<FlightSegmentSeatMap>
	{ }
}