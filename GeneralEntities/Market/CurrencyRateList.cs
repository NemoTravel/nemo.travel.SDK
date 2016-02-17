using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Market
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Rate")]
	public class CurrencyRateList : List<CurrencyRate>
	{
		public CurrencyRateList()
		{ }

		public CurrencyRateList(IEnumerable<CurrencyRate> data)
			: base(data)
		{ }
	}
}