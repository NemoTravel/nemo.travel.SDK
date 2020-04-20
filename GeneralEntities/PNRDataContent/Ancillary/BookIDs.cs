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

		public override bool Equals(object obj)
		{
			var other = obj as BookIDs;
			if (other == null)
			{
				return false;
			}

			return ID == other.ID && SupplierID == other.SupplierID;
		}

		public BookIDs Copy()
		{
			var result = new BookIDs();

			result.ID = ID;
			result.SupplierID = SupplierID;

			return result;
		}
	}
}