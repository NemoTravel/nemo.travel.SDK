using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Flight")]
	public class ScheduleFlightsCollection : List<ScheduleFlight>
	{
		public ScheduleFlightsCollection() : base() { }

		public ScheduleFlightsCollection(int capacity) : base(capacity) { }

		public ScheduleFlightsCollection(IEnumerable<ScheduleFlight> collection) : base(collection) { }
	}
}