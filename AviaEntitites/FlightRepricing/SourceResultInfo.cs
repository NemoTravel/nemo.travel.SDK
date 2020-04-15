using System.Collections.Concurrent;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "SourceResult", KeyName = "ID", ValueName = "Result")]
	public class SourceResultInfo : ConcurrentDictionary<int, string>
	{
	}
}