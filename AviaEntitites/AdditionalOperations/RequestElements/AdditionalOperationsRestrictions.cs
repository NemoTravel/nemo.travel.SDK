using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.RequestElements
{
	/// <summary>
	/// Содержит описание дополнительных условий для выполнения операций
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalOperationsRestrictions
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
	}
}