using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue.RequestElements
{
	/// <summary>
	/// Пакет реквизитов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Packages", ItemName = "PackageID")]
	public class PackagesList : List<int>
	{
		public PackagesList() : base() { }

		public PackagesList(IEnumerable<int> collection) : base(collection) { }
	}
}