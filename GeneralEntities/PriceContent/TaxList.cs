using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Tax")]
	public class TaxList : List<Tax>
	{
		public TaxList()
		{
		}

		public TaxList(IEnumerable<Tax> collection) : base(collection)
		{
		}
	}
}