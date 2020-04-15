using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SourceInfo
	{
		[DataMember(Order = 0, IsRequired = true)]
		public int ID { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public AviaSuppliers Supplier { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string DefaultTicketingRequisiteID { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public RequisiteConfigList CustomTicketingRequisites { get; set; }
	}
}