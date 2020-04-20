using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Список забронированных мест в самолёте
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookedSeats", ItemName = "Seat")]
	[Serializable]
	public class BookedSeatList : List<BookedSeat>
	{ }
}