using AviaEntities.SharedElements.Ancillaries.RequestElements;
using AviaEntities.SharedElements.Ancillaries.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries
{
	[KnownType(typeof(AncillaryServiceRQ))]
	[KnownType(typeof(AncillaryServiceRS))]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServices<T> : List<T> where T : BaseAncillaryService
	{
		public AncillaryServices() { }

		public AncillaryServices(IEnumerable<T> collection) : base(collection) { }
	}
}
