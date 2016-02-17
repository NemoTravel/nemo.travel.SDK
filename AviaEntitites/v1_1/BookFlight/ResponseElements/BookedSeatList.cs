using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Список забронированных мест в самолёте
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookedSeats", ItemName = "Seat")]
	public class BookedSeatList : List<BookedSeat>
	{
	}
}