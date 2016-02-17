using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Список этажей в самолёте
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Floors", ItemName = "Floor")]
	public class SeatMapFloorList : List<SeatMapFloor>
	{
	}
}