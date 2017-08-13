using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetRequestCountInfo
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "RequestCountBySubAgencies", KeyName = "SubAgencyID", ItemName = "RequestCountBySubAgency", ValueName = "RequestCountInfo")]
	public class RequestCountBySubAgencyDictionary : Dictionary<int, RequestCountInfo>
	{
	}
}
