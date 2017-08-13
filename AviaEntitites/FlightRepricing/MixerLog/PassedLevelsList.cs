using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Level")]
	public class PassedLevelsList : List<int> { }
}