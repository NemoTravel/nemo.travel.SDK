using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Type")]
	public class TypeList<T> : List<T>
	{
		public TypeList()
		{ }

		public TypeList(IEnumerable<T> list)
			: base(list)
		{ }
	}
}