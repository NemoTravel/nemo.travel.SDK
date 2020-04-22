using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Tax")]
	public class VatTaxList : List<VatTax>
	{
		public VatTaxList()
		{
		}

		public VatTaxList(int capacity)
			: base(capacity)
		{
		}

		public VatTaxList(IEnumerable<VatTax> collection)
			: base(collection)
		{
		}
	}
}