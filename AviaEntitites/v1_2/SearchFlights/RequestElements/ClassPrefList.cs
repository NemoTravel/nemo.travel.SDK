using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "ClassOfService")]
	public class ClassPrefList : List<ClassType>
	{
		public ClassPrefList()
		{ }

		public ClassPrefList(IEnumerable<ClassType> list)
			: base(list)
		{ }
	}
}