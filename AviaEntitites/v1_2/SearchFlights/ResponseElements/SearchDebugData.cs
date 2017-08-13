using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SearchDebugData
	{
		[DataMember(Order = 0, IsRequired = true)]
		public DateTimeEx StartTime { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public DateTimeEx EndTime { get; set; }

		[DataMember(Order = 2, IsRequired = true)]
		public bool IsComplete { get; set; }

		[DataMember(Order = 3, IsRequired = true)]
		public bool IsAsync { get; set; }

		[DataMember(Order = 4, IsRequired = true)]
		public SourceInfo Sources { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public List<SearchThreadInfo> SearchThreads { get; set; }
	}
}