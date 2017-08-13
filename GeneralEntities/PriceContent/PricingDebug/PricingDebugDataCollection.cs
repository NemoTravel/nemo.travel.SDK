using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "DebugData")]
	public class PricingDebugDataCollection : List<DebugData>
	{
		public PricingDebugDataCollection() : base() { }

		public PricingDebugDataCollection(IEnumerable<DebugData> collection) : base(collection) { }
	}
}
