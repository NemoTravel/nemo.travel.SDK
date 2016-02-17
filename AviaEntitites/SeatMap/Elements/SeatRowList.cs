using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Список рядом мест
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "SeatRows", ItemName = "SeatRow")]
	public class SeatRowList : List<SeatRow>
	{
	}
}