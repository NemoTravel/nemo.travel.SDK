using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class PeriodsCollection : List<Period>
	{
		public PeriodsCollection() : base() { }

		public PeriodsCollection(int capacity) : base(capacity) { }

		public PeriodsCollection(IEnumerable<Period> collection) : base(collection) { }
	}
}
