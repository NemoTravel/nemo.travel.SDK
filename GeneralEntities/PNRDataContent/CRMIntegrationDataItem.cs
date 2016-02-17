using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание специфичных данных для интеграции с CRM и бэкофисами на стороне поставщиков услуг
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CRMIntegrationDataItem
	{
		/// <summary>
		/// ИД клиента в CRM
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string ClientID { get; set; }

		/// <summary>
		/// ИД клиента в Немо
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int NemoClientID { get; set; }

		/// <summary>
		/// ИД заказа в Немо
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string OrderID { get; set; }

		/// <summary>
		/// ИД ценового правила
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public int PricingRuleID { get; set; }

		/// <summary>
		/// Способ оплаты заказа в Немо
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string PaymentGateway { get; set; }

		/// <summary>
		/// Сбор ПШ
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public Money PaymentGatewayMarkup { get; set; }

		/// <summary>
		/// Канал продажи
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public SalesChannel SalesChannel { get; set; }
	}
}