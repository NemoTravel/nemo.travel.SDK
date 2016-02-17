using AviaEntities.BookFlight.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Информация о пассажире, хранимая по результатам создания брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookedTraveller_1_1")]
	public class BookedTraveller : Traveller
	{
		/// <summary>
		/// Забронированные места для данного перелёта данного пассажира
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public BookedSeatList Seats { get; set; }

		/// <summary>
		/// Номера билетов данного пассажира
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public AcquiredDocuments AcquiredDocuments { get; set; }
	}
}