using System.Runtime.Serialization;

namespace AviaEntities.CloseSession
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CloseSessionRSBody
	{
		[DataMember(IsRequired = true, Order = 0)]
		public bool Success { get; set; }
	}
}