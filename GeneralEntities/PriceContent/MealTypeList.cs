using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "MealType")]
	public class MealTypeList : List<MealType>
	{
		public MealTypeList()
		{ }

		public MealTypeList(List<MealType> list)
			: base(list)
		{ }
	}
}