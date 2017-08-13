using GeneralEntities.Market;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "FOPPrice", KeyName = "FOP", ValueName = "PriceBreakdown")]
	public class FOPPriceList : Dictionary<string, PriceBreakdownList>
	{
		public FOPPriceList()
		{ }

		public FOPPriceList(Dictionary<string, PriceBreakdownList> arg)
			: base(arg)
		{ }
	}
}