using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.RefundTicket
{
	/// <summary>
	/// Тело запроса на сдачу билетов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RefundTicketRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Список пассажиров, билеты которых требуется сдать
		/// </summary>
		[DataMember(IsRequired = false, Order = 1)]
		public PassengerList Passengers { get; set; }
	}
}