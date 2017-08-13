using System.Runtime.Serialization;

namespace AviaEntities.GetRequestCountInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RequestCountInfo
	{
		[DataMember(Order = 1, IsRequired = true)]
		public int Searches { get; set; }

		[DataMember(Order = 2, IsRequired = true)]
		public int Tickets { get; set; }
	}
}
