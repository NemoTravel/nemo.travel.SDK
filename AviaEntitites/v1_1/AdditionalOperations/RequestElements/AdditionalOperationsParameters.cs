using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations.RequestElements
{
	/// <summary>
	/// Содержит описание параметров для выполнения операций
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalOperationsParameters
	{
		/// <summary>
		/// Проверка доступности через запрос взятия мест
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public bool CheckAvailabilityWithBookingRequest { get; set; }

		/// <summary>
		/// Дополнительная информация для получения актуальной цены перелёта
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PricingInfo PricingInfo { get; set; }

		/// <summary>
		/// Включает получение тарифных правил от ГДС и обновление закэшированных в брони данных
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool UpdateCachedFareRules { get; set; }
	}
}