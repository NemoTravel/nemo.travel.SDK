using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "SourceID")]
	public class SourceList : List<int>
	{
		public SourceList() : base() { }

		public SourceList(IEnumerable<int> collection) : base(collection) { }
	}
}