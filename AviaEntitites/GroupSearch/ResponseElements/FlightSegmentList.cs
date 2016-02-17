using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список сгруппированных сегментов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "OrderedFlightSegments", ItemName = "FlightSegment")]
	public class FlightSegmentList : List<FlightSegmentBinding>
	{
		/// <summary>
		/// Дефолтный конструктор, необходим для работы сериализаторов
		/// </summary>
		public FlightSegmentList()
		{ }
	}
}