using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Services;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Segment
	{
		[DataMember(Order = 0)]
		public TripPointInformation TripPoint { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public DateTimeEx ArrivalTime { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? ArrivalDateOffset { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx DepartureTime { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public int? DepartureDateOffset { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string RegistrationType { get; set; }
	}
}
