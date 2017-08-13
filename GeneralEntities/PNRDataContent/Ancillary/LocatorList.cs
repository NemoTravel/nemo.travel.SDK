using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Locator")]
	public class LocatorList : List<string>
	{
		public LocatorList()
		{ }

		public LocatorList(IEnumerable<string> arg)
			: base(arg)
		{ }
	}
}