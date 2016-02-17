using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Traveller")]
	public class ModifyTravellerInformationList : List<ModifyTravellerInformation>
	{
	}
}
