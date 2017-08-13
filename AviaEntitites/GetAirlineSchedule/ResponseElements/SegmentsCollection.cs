using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Segment")]
	public class SegmentsCollection : List<Segment>
	{
		public SegmentsCollection() : base() { }

		public SegmentsCollection(int capacity):base(capacity) { }

		public SegmentsCollection(IEnumerable<Segment> collection) : base(collection) { }
	}
}
