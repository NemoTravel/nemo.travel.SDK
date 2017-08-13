using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.GetSearchResults
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RAWSearchResultData
	{
		[DataMember(Order = 0)]
		public long ServiceLogID { get; set; }

		[DataMember(Order = 1)]
		public int OriginalSourceID { get; set; }

		[DataMember(Order = 2)]
		public DateTimeEx SearchDT { get; set; }

		[DataMember(Order = 3)]
		public string RequestName { get; set; }

		[DataMember(Order = 4)]
		public string Request { get; set; }

		[DataMember(Order = 5)]
		public string Response { get; set; }
	}
}