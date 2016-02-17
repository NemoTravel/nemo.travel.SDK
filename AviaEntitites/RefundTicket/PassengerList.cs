using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.RefundTicket
{
	/// <summary>
	/// Список пассажиров
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name="TicketsToRefund", ItemName="PassengerNumber")]
	public class PassengerList : List<int>
	{
	}
}