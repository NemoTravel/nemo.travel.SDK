using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.RequestResponse
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Locator")]
	public class PNRLocatorsList : List<string>
	{
		public PNRLocatorsList() : base() { }

		public PNRLocatorsList(IEnumerable<string> collection) : base(collection) { }
	}
}