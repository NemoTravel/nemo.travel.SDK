using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.ImportBook.RequestElements
{
	[DataContract(Namespace = "http://nemo.travel/Avia")]
	public class SourceDescription
	{
		[DataMember(Order = 0, IsRequired = true)]
		public AviaSuppliers Supplier { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public string SupplierRequisiteID { get; set; }
	}
}