using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServicesPrices : List<AncillaryServicePrice>
	{
	}
}