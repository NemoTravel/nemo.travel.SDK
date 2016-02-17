using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "ModifyDataItem")]
	public class ModifyPNRDataItemList : List<ModifyPNRDataItem>
	{
	}
}