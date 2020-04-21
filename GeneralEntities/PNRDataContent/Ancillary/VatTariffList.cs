using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[CollectionDataContract(Namespace = "http://nemo.travel/STL", ItemName = "Tariff")]
	public class VatTariffList : List<VatTariff>
	{
		public VatTariffList() { }

		public VatTariffList(int capacity) : base(capacity) { }

		public VatTariffList(IEnumerable<VatTariff> collection) : base(collection) { }
	}
}