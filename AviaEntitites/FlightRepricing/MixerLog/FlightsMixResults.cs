using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Flight")]
	public class FlightsMixResults : List<FlightMixData> { }
}