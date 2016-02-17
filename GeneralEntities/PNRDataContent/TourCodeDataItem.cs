using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TourCodeDataItem
	{
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public TourCodeType Type { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public string Value { get; set; }
	}
}