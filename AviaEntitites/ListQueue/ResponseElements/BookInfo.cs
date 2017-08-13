using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookInfo
	{
		[DataMember(Order = 0)]
		public long BookID { get; set; }

		[DataMember(Order = 1)]
		public string Locator { get; set; }

		[DataMember(Order = 2)]
		public AviaSuppliers Supplier { get; set; }
	}
}