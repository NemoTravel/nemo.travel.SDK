using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "ID")]
	public class UserHierarchy : List<int>
	{
	}
}