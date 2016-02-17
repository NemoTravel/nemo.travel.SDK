using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "PassengerTypePrice")]
	public class PassengerTypePriceBreakdownList : List<PassengerTypePriceBreakdown>
	{
	}
}