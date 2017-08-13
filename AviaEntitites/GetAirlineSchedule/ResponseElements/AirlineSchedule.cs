using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AirlineSchedule
	{
		[DataMember(Order = 0)]
		public ScheduleFlightsCollection Flights { get; set; }
	}
}
