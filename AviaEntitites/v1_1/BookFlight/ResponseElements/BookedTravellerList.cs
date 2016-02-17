using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Список пассажиров в брони
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Travellers_1_1", ItemName = "Traveller")]
	public class BookedTravellerList : List<BookedTraveller>
	{ }
}