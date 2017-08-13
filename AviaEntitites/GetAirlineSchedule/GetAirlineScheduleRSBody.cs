using AviaEntities.GetAirlineSchedule.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetAirlineScheduleRSBody
	{
		[DataMember(Order = 0)]
		public AirlineSchedule AirlineSchedule { get; set; }
	}
}
