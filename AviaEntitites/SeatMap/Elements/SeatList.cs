using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Список мест
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Seats", ItemName = "Seat")]
	public class SeatList : List<Seat>
	{
		public SeatList() : base() { }

		public SeatList(IEnumerable<Seat> collection) : base(collection) { }
	}
}