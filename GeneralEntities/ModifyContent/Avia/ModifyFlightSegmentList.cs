using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent.Avia
{
	/// <summary>
	/// Массив сегментов перелёта для модификации
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName="Segment")]
	public class ModifyFlightSegmentList : List<ModifyFlightSegment>
	{
	}
}