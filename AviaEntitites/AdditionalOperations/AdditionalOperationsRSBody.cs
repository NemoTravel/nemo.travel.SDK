using AviaEntities.AdditionalOperations.RequestElements;
using AviaEntities.AdditionalOperations.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalOperationsRSBody
	{
		/// <summary>
		/// Объект, для которого выполнялись операции
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public ObjectForOperations ObjectForOperations { get; set; }

		/// <summary>
		/// Результат проверки доступности
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public CheckAvailabilityResult CheckAvailabilityResult { get; set; }

		/// <summary>
		/// Результат получения тарифных правил
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public GetFareRulesResult GetFareRulesResult { get; set; }

		/// <summary>
		/// Результат получения карты мест
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public GetSeatMapResult GetSeatMapResult { get; set; }

		/// <summary>
		/// Результат получения актуальной цены
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public GetPriceResult GetPriceResult { get; set; }

		/// <summary>
		/// Результат поиска допуслуг
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public FindAdditionalServicesResult FindAdditionalServicesResult { get; set; }

		/// <summary>
		/// Результат получения допустимых кредитных карт
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public GetAllowedCCsResult GetAllowedCCsResult { get; set; }

		/// <summary>
		/// Результат получения а/к, чьи карточки лояльности принимаются на перелёте
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public GetAllowedLoyaltyCardsResult GetAllowedLoyaltyCardsResult { get; set; }
	}
}