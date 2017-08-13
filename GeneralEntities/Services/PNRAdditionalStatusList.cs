using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Status")]
	public class PNRAdditionalStatusList : HashSet<PNRAdditionalStatus>
	{
		public PNRAdditionalStatusList()
		{ }

		public PNRAdditionalStatusList(HashSet<PNRAdditionalStatus> hashSet)
			: base(hashSet)
		{ }
	}
}