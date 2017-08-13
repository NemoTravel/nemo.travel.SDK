using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "SourceResult", KeyName = "ID", ValueName = "Result")]
	public class SourceResultInfo : Dictionary<int, string>
	{
	}
}