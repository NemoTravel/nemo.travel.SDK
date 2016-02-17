using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Список пассажиров в брони
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Travellers", ItemName = "Traveller")]
	[Serializable]
	public class BookedTravellerList : List<BookedTraveller>
	{
		public BookedTravellerList()
		{ }

		public BookedTravellerList(List<BookedTraveller> arg)
			: base(arg)
		{ }
	}
}