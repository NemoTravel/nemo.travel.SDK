using System.Runtime.Serialization;

namespace AviaEntities.OpenSession
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class OpenSessionRSBody
	{
		[DataMember(IsRequired = true, Order = 0)]
		public string SessionID { get; set; }
	}
}