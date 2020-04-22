using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[DataContract(Namespace = "http://nemo.travel/Avia")]
	public class RequisiteConfig
	{
		[DataMember(Order = 0, IsRequired = true)]
		public string AppliesToCompanies { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public string RequisiteID { get; set; }
	}
}
