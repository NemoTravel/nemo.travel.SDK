using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetAirlineSchedule.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Class")]
	public class ClassesCollection : HashSet<BaseClass>
	{
		public ClassesCollection() : base() { }

		public ClassesCollection(IEnumerable<BaseClass> collection) : base(collection) { }
	}
}
