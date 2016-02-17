using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.Ticketing.RequestElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FinancialInfo
	{
		/// <summary>
		/// Комиссия а/к
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public ServiceCommission AirlineComission { get; set; }

		/// <summary>
		/// Собственная субагентская комиссия (часть от комиссии а/к)
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public ServiceCommission SelfSubagentComission { get; set; }

		/// <summary>
		/// Сбор агента, необходим в некоторых случаях для выписки в Американских РСС
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Money Markup { get; set; }

		/// <summary>
		/// ПШ, с помощью которого оплачена бронь, необходим в случае оплаты с ГДС процессингом и/или скидой броней из Сэйбра
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public PaidWithInfo PaidWith { get; set; }

		/// <summary>
		/// Скидка
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Money Discount { get; set; }
	}
}