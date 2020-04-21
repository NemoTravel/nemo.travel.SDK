using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo.travel/Avia", ItemName = "TriggeredRequestFilter")]
	public class TriggeredRequestFiltersList : List<TriggeredRequestFilter>
	{
	}
}