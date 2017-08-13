using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Day")]
	public class DayOfWeekCollection : HashSet<DayOfWeek>
	{
		public DayOfWeekCollection() : base() { }

		public DayOfWeekCollection(IEnumerable<DayOfWeek> collection) : base(collection) { }
	}
}
