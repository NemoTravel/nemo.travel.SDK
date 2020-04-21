using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(ItemName = "SubsidyInformation", Namespace = "http://nemo-ibe.com/Avia")]
	public class SubsidyInformationList : List<SubsidyInformation>
	{
		public SubsidyInformationList() { }

		public SubsidyInformationList(List<SubsidyInformation> list) : base(list) { }
	}
}
