using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "User")]
	public class UsersCollection : HashSet<string>
	{
		public UsersCollection() : base() { }

		public UsersCollection(IEnumerable<string> collection) : base(collection) { }
	}
}
