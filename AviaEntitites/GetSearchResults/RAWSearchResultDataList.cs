using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetSearchResults
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "LogData")]
	public class RAWSearchResultDataList : List<RAWSearchResultData>
	{
	}
}