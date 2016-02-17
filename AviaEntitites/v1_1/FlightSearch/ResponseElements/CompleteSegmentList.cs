using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Сегменты перелёта
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Segments_1_1", ItemName = "Segment")]
	public class CompleteSegmentList : List<CompleteSegment>
	{
	}
}