using AviaEntities.SeatMap.Elements;
using System.Runtime.Serialization;

namespace AviaEntities.SeatMap
{
	/// <summary>
	/// Тело ответа поиска карты мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SeatMapRSBody
	{
		/// <summary>
		/// Карта мест для каждого из сегментов перелёта
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public FlightSeatMap SeatMapSegments { get; set; }
	}
}