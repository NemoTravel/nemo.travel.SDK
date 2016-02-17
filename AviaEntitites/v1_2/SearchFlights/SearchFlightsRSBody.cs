using AviaEntities.v1_1.FlightSearch.ResponseElements;
using AviaEntities.v1_1.GroupSearch;
using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SearchFlightsRSBody
	{
		/// <summary>
		/// Выдача без группировки
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public FlightList PlaneFlights { get; set; }

		/// <summary>
		/// Простая группировка
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public GroupedFlightResultBody SimpleGroupedFlights { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }
	}
}