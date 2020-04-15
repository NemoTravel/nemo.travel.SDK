using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", Name = "Rules", ItemName = "Rule")]
	public class FareRuleList : List<FareRule>
	{
	}
}