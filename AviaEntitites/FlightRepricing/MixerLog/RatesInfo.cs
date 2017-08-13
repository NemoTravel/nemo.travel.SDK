using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", KeyName = "FromCurrency", ValueName = "Rate", ItemName = "RateInfo")]
	public class RatesInfo : Dictionary<string, float> { }
}
