using GeneralEntities.BookContent;
using System.Runtime.Serialization;

namespace AviaEntities.Exchange
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ExchangeTicketRSBody
	{
		/// <summary>
		/// ИД брони с пассажирами, билеты которых не обменивались
		/// </summary>
		[DataMember(Order = 1, IsRequired = false, EmitDefaultValue = false)]
		public long? BookIDWithNotExchangedTickets { get; set; }

		/// <summary>
		/// Бронь с пассажирами, билеты которых были обменены
		/// </summary>
		[DataMember(Order = 1, IsRequired = false, EmitDefaultValue = false)]
		public Book BookWithExchangedTickets { get; set; }
	}
}