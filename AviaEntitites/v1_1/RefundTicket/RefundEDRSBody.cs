using GeneralEntities.BookContent;
using GeneralEntities.Refund;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.RefundTicket
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RefundEDRSBody
	{
		/// <summary>
		/// Информация о возвратах билетов
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public EDRefundDataList TicketsRefundData { get; set; }

		/// <summary>
		/// Информация о возвратах ЕМД
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public EDRefundDataList EMDsRefundData { get; set; }

		/// <summary>
		/// В случае частичного возврата - бронь с невозвращенными билетами
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Book ActiveBook { get; set; }

		/// <summary>
		/// В случае частичного возврата - бронь с билетами для сдачи
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public Book SplitedBook { get; set; }

		/// <summary>
		/// В случае частичного возврата - локатор ПНРа с возвращенными билетами
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string SplitedPNRLocator { get; set; }
	}
}