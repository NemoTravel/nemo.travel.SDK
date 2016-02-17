using AviaEntities.SeatMap.Elements;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат получения карты мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetSeatMapResult
	{
		/// <summary>
		/// Карта мест для каждого из сегментов перелёта
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public FlightSeatMap SeatMapSegments { get; set; }
	}
}