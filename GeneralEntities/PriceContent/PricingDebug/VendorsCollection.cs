using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Code")]
	public class VendorsCollection : List<string> { }
}