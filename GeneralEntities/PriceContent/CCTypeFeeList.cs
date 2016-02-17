using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "CCTypeFee")]
	public class CCTypeFeeList : List<CCTypeFee>
	{
		public CCTypeFeeList()
		{ }

		public CCTypeFeeList(List<CCTypeFee> list)
			: base(list)
		{ }
	}
}