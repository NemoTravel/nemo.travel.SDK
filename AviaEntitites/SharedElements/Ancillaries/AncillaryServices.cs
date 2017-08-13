using AviaEntities.SharedElements.Ancillaries.RequestElements;
using AviaEntities.SharedElements.Ancillaries.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[KnownType(typeof(AncillaryServiceRQ))]
	[KnownType(typeof(AncillaryServiceRS))]
	public class AncillaryServices<T> : List<T> where T : BaseAncillaryService
	{
	}
}
