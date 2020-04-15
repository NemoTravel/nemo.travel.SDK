using AviaEntities.AdditionalOperations.RequestElements;
using AviaEntities.AdditionalOperations.ResponseElements;
using AviaEntities.FlightRepricing;
using AviaEntities.SeatMap;
using AviaEntities.v1_1.AdditionalOperations.ResponseElements;
using AviaEntities.v1_1.FlightSearch.ResponseElements;
using AviaEntities.v1_2.SearchFlights.ResponseElements;
using GeneralEntities.PriceContent.PricingDebug;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations
{
	/// <summary>
	/// Тело ответа на запросе выполнения допопераций v1.1
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AdditionalOperationsRSBody_1_1")]
	public class AdditionalOperationsRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public SourceInfoList Sources { get; set; }

		/// <summary>
		/// Объект, для которого выполнялись операции
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public ObjectForOperations ObjectForOperations { get; set; }

		/// <summary>
		/// Результат проверки доступности
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public CheckAvailabilityResult CheckAvailabilityResult { get; set; }

		/// <summary>
		/// Результат получения тарифных правил
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public GetFareRulesResult GetFareRulesResult { get; set; }

		/// <summary>
		/// Результат получения карты мест
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public SeatMapRSBody GetSeatMapResult { get; set; }

		/// <summary>
		/// Результат получения актуальной цены
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public FlightList GetPriceResult { get; set; }

		/// <summary>
		/// Результат поиска допуслуг
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public AncillaryServicesSearchResult FindAdditionalServicesResult { get; set; }

		/// <summary>
		/// Результат получения допустимых кредитных карт
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public GetAllowedCCsResult GetAllowedCCsResult { get; set; }

		/// <summary>
		/// Результат получения а/к, чьи карточки лояльности принимаются на перелёте
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public GetAllowedLoyaltyCardsResult GetAllowedLoyaltyCardsResult { get; set; }

		/// <summary>
		/// Актуализированный перелёт
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Flight ActualizedFlight { get; set; }

		/// <summary>
		/// Результат получения семейств
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public FlightList FlightsByFareFamily { get; set; }

		/// <summary>
		/// Результат репрайсинга перелёта
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public FlightRepricingRSBody FlightRepricingResult { get; set; }

		/// <summary>
		/// Субсидированные тарифы
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public FlightList SubsidizedTariffs { get; set; }

		/// <summary>
		/// Отладка ценообразования
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public PricingDebugDataCollection PricingDebugLogs { get; set; }

		[DataMember(Order = 14)]
		public bool ResultsFiltersApplied { get; set; }

		public AdditionalOperationsRSBody()
		{
			Sources = new SourceInfoList();
		}
	}
}