using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BookIDs
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public long? ID { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string SupplierID { get; set; }
	}
}