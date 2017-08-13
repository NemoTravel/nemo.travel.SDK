using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SearchThreadInfo
	{
		[DataMember(Order = 0, IsRequired = true)]
		public int SourceID { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public bool IsComplete { get; set; }

		[DataMember(Order = 2, IsRequired = true)]
		public DateTimeEx StartTime { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string Duration { get; set; }

		[DataMember(Order = 4, IsRequired = true)]
		public bool FromCache { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string OriginalSearchID { get; set; }
	}
}