using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "SourceInfo", KeyName = "ID", ValueName = "Supplier")]
	public class SourceInfo : Dictionary<int, AviaSuppliers>
	{
		public SourceInfo()
		{ }

		public SourceInfo(Dictionary<int, AviaSuppliers> arg) : base(arg)
		{ }
	}
}