using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ScheduleFlights", ItemName = "ScheduleFlight")]
	public class ScheduleFlightList : List<ScheduleFlight>
	{
	}
}
