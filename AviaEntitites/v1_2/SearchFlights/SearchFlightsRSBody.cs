using AviaEntities.v1_1.FlightSearch.ResponseElements;
using AviaEntities.v1_1.GroupSearch;
using AviaEntities.v1_2.SearchFlights.ResponseElements;
using GeneralEntities.Market;
using GeneralEntities.PriceContent;
using GeneralEntities.PriceContent.PricingDebug;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SearchFlightsRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public SearchDebugData SearchData { get; set; }

		/// <summary>
		/// Выдача без группировки
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public FlightList PlaneFlights { get; set; }

		/// <summary>
		/// Простая группировка
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public GroupedFlightResultBody SimpleGroupedFlights { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public FareFamilyDescriptionList FareFamiliesDescription { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public SubsidyInformationList SubsidiesInformation { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public PricingDebugDataCollection PricingDebugLog { get; set; }

		public int GetSearchResultCount()
		{
			if (PlaneFlights != null)
			{
				return PlaneFlights.Count;
			}

			if (SimpleGroupedFlights != null)
			{
				return SimpleGroupedFlights.FlightPriceGroups.Sum(flights => flights.Flights.Count);
			}

			return 0;
		}
	}
}