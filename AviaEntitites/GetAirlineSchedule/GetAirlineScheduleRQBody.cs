using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetAirlineScheduleRQBody
	{
		[DataMember(Order = 0)]
		public int SourceID { get; set; }

		[DataMember(Order = 1)]
		public string AirlineCode { get; set; }
	}
}
