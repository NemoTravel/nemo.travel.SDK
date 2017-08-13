using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetRequestCountInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetRequestCountInfoRSBody
	{
		[DataMember(Order = 0, IsRequired = false)]
		public List<DatedRequestCountInfo> RequestCountInfo { get; set; }
	}
}
