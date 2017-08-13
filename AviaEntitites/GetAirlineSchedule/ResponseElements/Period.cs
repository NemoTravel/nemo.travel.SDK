using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Period
	{
		[DataMember(Order = 0)]
		public DateTimeEx StartDate { get; set; }

		[DataMember(Order = 1)]
		public DateTimeEx EndDate { get; set; }

		[DataMember(Order = 2)]
		public DayOfWeekCollection DaysOfWeek { get; set; }

		[DataMember(Order = 3)]
		public string AircraftType { get; set; }

		[DataMember(Order = 4)]
		public ClassesCollection Classes { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string CodeSharing { get; set; }

		[DataMember(Order = 6)]
		public SegmentsCollection Segments { get; set; }
	}
}
