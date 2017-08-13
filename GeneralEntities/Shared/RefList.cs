using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Ref")]
	public class RefList<T> : List<T>
	{
		public RefList() { }

		public RefList(IEnumerable<T> list) : base(list) { }

		public RefList<T> Clone()
		{
			return new RefList<T>(this);
		}

		public static bool Equals(RefList<T> a, RefList<T> b)
		{
			return a == null && b == null ||
				a != null && b != null && a.Count == b.Count && a.All(item => b.Contains(item));
		}
	}
}