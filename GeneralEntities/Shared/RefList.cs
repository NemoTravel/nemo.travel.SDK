using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Ref")]
	public class RefList<T> : List<T>
	{
		public RefList()
		{ }

		public RefList(IEnumerable<T> list)
			: base(list)
		{ }
	}
}