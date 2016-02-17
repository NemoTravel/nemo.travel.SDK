using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "PricePart")]
	public class PriceBreakdownList : List<PriceBreakdown>
	{
	}
}