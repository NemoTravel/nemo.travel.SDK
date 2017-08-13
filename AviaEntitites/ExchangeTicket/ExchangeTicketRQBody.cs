using AviaEntities.SharedElements;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.Exchange
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ExchangeTicketRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// ИД перелёта, на который будет производиться обмен
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string FlightID { get; set; }

		/// <summary>
		/// Список пассажиров, билеты которых требуется обменять
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public RefList<int> Passengers { get; set; }
	}
}