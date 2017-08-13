using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.ResponseElements
{
	/// <summary>
	/// Сегменты перелёта
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ScheduleSegments", ItemName = "ScheduleSegment")]
	public class ScheduleCompleteSegmentList : List<ScheduleCompleteSegment>
	{
		public ScheduleCompleteSegmentList()
		{ 
		}

		public ScheduleCompleteSegmentList(IEnumerable<ScheduleCompleteSegment> segments) : base(segments)
		{
		}
	}
}