using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Packages", ItemName = "PackageID")]
	public class PackagesList : List<int>
	{ }
}