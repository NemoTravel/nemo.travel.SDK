using System.Runtime.Serialization;

namespace AviaEntities.GetBansInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetBansInfoRSBody
	{
		[DataMember(Order = 0, IsRequired = true)]
		public BanList Bans { get; set; }
	}
}