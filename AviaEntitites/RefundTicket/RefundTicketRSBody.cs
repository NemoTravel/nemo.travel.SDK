using GeneralEntities.BookContent;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.RefundTicket
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RefundTicketRSBody
	{
		/// <summary>
		/// Информация о возвратах билетов
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public List<RefundedTicket> Refunds { get; set; }

		/// <summary>
		/// В случае частичного возврата - бронь с невозвращенными билетами
		/// </summary>
		[DataMember(Order = 1, IsRequired = false, EmitDefaultValue = false)]
		public Book ActiveBook { get; set; }

		/// <summary>
		/// В случае частичного возврата - бронь с билетами для сдачи
		/// </summary>
		[DataMember(Order = 2, IsRequired = false, EmitDefaultValue = false)]
		public Book SplitedBook { get; set; }

		/// <summary>
		/// В случае частичного возврата - локатор ПНРа с возвращенными билетами
		/// </summary>
		[DataMember(Order = 3, IsRequired = false, EmitDefaultValue = false)]
		public string SplitedPNRLocator { get; set; }


		public RefundTicketRSBody()
		{
			Refunds = new List<RefundedTicket>();
		}
	}
}