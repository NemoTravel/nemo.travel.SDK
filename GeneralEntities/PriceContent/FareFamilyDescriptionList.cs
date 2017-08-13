using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Description")]
	public class FareFamilyDescriptionList : List<FareFamilyDescription>
	{
		public FareFamilyDescriptionList()
		{ }

		public FareFamilyDescriptionList(List<FareFamilyDescription> list)
			: base(list)
		{ }
	}
}