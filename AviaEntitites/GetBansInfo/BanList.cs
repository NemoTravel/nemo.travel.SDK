using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetBansInfo
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Bans", ItemName = "Ban")]
	public class BanList : List<BanInfo>
	{
	}
}