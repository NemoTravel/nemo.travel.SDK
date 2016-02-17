using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "DaysOfWeek", ItemName = "DayOfWeek")]
	public class DaysOfWeekList : List<DayOfWeek>
	{
	}
}
