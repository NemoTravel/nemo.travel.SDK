using AviaEntities.v1_2.SearchFlights;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.GetSearchResults
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetSearchResultsRSBody : SearchFlightsRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RAWSearchResultDataList RAWData { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public TextList PropagationLog { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string SearchRequest { get; set; }
	}
}