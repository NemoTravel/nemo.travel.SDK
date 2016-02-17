using AviaEntities.Ticketing.RequestElements;
using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.Ticketing.RequestElements
{
	/// <summary>
	/// Финансовая информация v1.1
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FinancialInfo_1_1")]
	public class FinancialInfo
	{
		/// <summary>
		/// Общая комиссия для всех пассажиров
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public ComissionInfo Comission { get; set; }

		/// <summary>
		/// Своя комиссия для каждого типа пассажира
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public CustomComission CustomComission { get; set; }

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