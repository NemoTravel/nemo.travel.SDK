using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Массив номеров билетов
	/// </summary>
	[Serializable]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Tickets", ItemName = "Ticket")]
	public class TicketList : List<TicketInfo>
	{
	}
}