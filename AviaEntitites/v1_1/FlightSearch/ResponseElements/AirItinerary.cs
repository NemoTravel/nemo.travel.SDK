using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Базовая информация о сегменте перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AirItinerary_1_1")]
	public class AirItinerary : ItemIdentification<long>
	{
		/// <summary>
		/// Аэропорт отправления
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public AirportInformation DepAirp { get; set; }

		/// <summary>
		/// Аэропорт прибытия
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public AirportInformation ArrAirp { get; set; }
	}
}