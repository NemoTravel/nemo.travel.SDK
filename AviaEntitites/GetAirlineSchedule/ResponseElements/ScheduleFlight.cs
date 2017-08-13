using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AirlineScheduleFlight")]
	public class ScheduleFlight
	{
		[DataMember(Order = 0)]
		public string Company { get; set; }

		[DataMember(Order = 1)]
		public string FlightNumber { get; set; }

		[DataMember(Order = 2)]
		public PeriodsCollection Periods { get; set; }
	}
}
