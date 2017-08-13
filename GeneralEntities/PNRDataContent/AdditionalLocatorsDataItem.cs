using GeneralEntities.PNRDataContent.Ancillary;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class AdditionalLocatorsDataItem
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string GalileoHostLocator { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public LocatorList Other { get; set; }
	}
}