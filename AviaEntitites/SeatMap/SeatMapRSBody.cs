using AviaEntities.SeatMap.Elements;
using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.SeatMap
{
	/// <summary>
	/// Тело ответа поиска карты мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SeatMapRSBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Карта мест для каждого из сегментов перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public FlightSeatMap SeatMapSegments { get; set; }
	}
}