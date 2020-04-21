using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.AdditionalLocators
{
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class SirenaCharterLocator
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Provider;

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Locator;
	}
}