using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[KnownType(typeof(AirTariff))]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Tariff")]
	public class TariffList : List<BaseTariff>
	{
	}
}