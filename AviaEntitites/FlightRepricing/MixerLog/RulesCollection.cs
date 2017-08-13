using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Rule", KeyName = "ID", ValueName = "Data")]
	public class RulesCollection : Dictionary<int, RuleData> { }
}
