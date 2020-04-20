using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.ExchangeTicket
{
	[DataContract(Namespace = "http://nemo.travel/Avia")]
	public abstract class CommonExchangeTicketRSBody<TBook>
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
		public TBook BookWithExchangedTickets { get; set; }
	}
}