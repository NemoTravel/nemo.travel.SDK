using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	/// <summary>
	/// Список ID пакетов, на которые указывает правило маршрутизации
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo.travel/Avia", ItemName = "PackageID")]
	public class PackageList : List<int>
	{
		public PackageList()
		{
		}

		public PackageList(IEnumerable<int> collection) : base(collection)
		{
		}
	}
}