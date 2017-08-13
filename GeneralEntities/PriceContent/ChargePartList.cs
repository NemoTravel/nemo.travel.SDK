using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Charge")]
	public class ChargePartList : List<ChargePart>
	{
		public ChargePartList() : base() { }

		public ChargePartList(IEnumerable<ChargePart> collection) : base(collection) { }
	}
}