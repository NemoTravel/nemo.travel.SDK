using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Status")]
	public class PNRAdditionalStatusList : List<PNRAdditionalStatus>
	{
		public PNRAdditionalStatusList()
		{ }

		public PNRAdditionalStatusList(List<PNRAdditionalStatus> list) : base(list)
		{ }
	}
}