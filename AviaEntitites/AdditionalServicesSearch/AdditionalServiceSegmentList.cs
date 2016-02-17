using AviaEntities.FlightSearch.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalServicesSearch
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "AvailableAdditionalServices", KeyName = "SegmentNumber", ValueName = "AdditionalServices")]
	public class AdditionalServiceSegmentList : Dictionary<int, List<AdditionalService>>
	{
	}
}