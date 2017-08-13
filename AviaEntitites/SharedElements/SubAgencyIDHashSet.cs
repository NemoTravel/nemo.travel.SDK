using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "SubAgenciesIDs", ItemName = "ID")]
	public class SubAgencyIDHashSet : HashSet<int>
	{
	}
}