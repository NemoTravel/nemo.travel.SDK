using AviaEntities.SharedElements;
using GeneralEntities.Shared;
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
		/// Список пассажиров, билеты которых требуется сдать билеты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true, Name = "Passengers")]
		public RefList<int> Travellers { get; set; }

		/// <summary>
		/// Признак вынужденного возврата
		/// </summary>
		[DataMember(Order = 1, IsRequired = false)]
		public bool Involuntary { get; set; }
	}
}