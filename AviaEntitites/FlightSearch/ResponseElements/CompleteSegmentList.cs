using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Сегменты перелёта
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Segments", ItemName = "Segment")]
	[Serializable]
	public class CompleteSegmentList : List<CompleteSegment>
	{
	}
}