using System;
using System.Runtime.Serialization;

namespace AviaEntities.GetRequestCountInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class DatedRequestCountInfo
	{
		[DataMember(Order = 1, IsRequired = true)]
		public DateTime Date { get; set; }

		[DataMember(Order = 2, IsRequired = true)]
		public RequestCountBySubAgencyDictionary RequestCountBySubAgencies { get; set; }
	}
}
