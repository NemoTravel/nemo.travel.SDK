using AviaEntities.SharedElements.ExchangeTicket;
using GeneralEntities.BookContent;
using System.Runtime.Serialization;

namespace AviaEntities.Exchange
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ExchangeTicketRSBody : CommonExchangeTicketRSBody<Book>
	{
	}
}