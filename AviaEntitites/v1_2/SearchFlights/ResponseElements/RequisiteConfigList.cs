using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo.travel/Avia", ItemName = "RequisiteConfig")]
	public class RequisiteConfigList : List<RequisiteConfig>
	{
		public RequisiteConfigList() { }

		public RequisiteConfigList(IEnumerable<RequisiteConfig> value) : base(value) { }
	}
}
