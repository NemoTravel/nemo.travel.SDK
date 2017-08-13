using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Group")]
	public class MixResults : List<GroupMixResult>
	{
		public new void Add(GroupMixResult result)
		{
			result.GroupID = Count + 1;
			base.Add(result);
		}
	}
}