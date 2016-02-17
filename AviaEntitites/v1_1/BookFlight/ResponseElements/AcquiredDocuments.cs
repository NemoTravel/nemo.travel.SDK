using AviaEntities.BookFlight.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Информация о приобритённых документах
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AcquiredDocuments
	{
		/// <summary>
		/// Билеты
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public TicketList Tickets { get; set; }

		/// <summary>
		/// Список EMD для данного пассажира
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public EMDList EMDs { get; set; }
	}
}