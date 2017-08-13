using AviaEntities.v1_2.SearchFlights;
using System.Runtime.Serialization;

namespace AviaEntities.GetSearchResults
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetSearchResultsRSBody : SearchFlightsRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RAWSearchResultDataList RAWData { get; set; }
	}
}