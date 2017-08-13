using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "ID")]
	public class IDList<T> : List<T>
	{
		public IDList()
		{ }

		public IDList(IEnumerable<T> list)
			: base(list)
		{ }
	}
}
