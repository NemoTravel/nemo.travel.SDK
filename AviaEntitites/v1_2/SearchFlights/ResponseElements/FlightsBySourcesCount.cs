using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", KeyName = "SourceID", ValueName = "Count", ItemName = "SourceData")]
	public class FlightsBySourcesCount : Dictionary<int, int>
	{
		public void Add(int source)
		{
			if (!ContainsKey(source))
			{
				Add(source, 0);
			}
			this[source]++;
		}
	}
}