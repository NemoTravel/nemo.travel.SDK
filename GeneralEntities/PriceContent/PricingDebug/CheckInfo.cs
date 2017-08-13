using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CheckInfo
	{
		[DataMember(Order = 0)]
		public string Value { get; set; }

		[DataMember(Order = 1)]
		public bool Result { get; set; }
	}
}