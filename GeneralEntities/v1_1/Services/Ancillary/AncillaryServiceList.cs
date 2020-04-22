using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.v1_1.Services.Ancillary
{
	/// <summary>
	/// Список допуслуг
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo.travel/STL", ItemName = "AncillaryService")]
	public class AncillaryServiceList : List<FlightAncillaryService>
	{
		public AncillaryServiceList() { }

		public AncillaryServiceList(IEnumerable<FlightAncillaryService> collection) : base(collection) { }
	}
}