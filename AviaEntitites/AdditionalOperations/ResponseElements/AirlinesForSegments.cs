using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// АПИ обёртка над списком а/к для каждого из сегментов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "AirlinesForSegment", KeyName = "SegmentNumber", ValueName="Airlines")]
	public class AirlinesForSegments : Dictionary<int, AirlineList>
	{
	}
}