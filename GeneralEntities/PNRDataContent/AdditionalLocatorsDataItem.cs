using GeneralEntities.PNRDataContent.Ancillary.AdditionalLocators;
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

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string HostLocator { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public AviaSuppliers? HostSupplier { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public SirenaCharterLocator SirenaCharterLocator;


		public override bool Equals(object obj)
		{
			var other = obj as AdditionalLocatorsDataItem;
			if (other == null)
			{
				return false;
			}


			if (Other == null && other.Other != null || Other != null && other.Other == null)
			{
				return false;
			}

			if (Other != null && (Other.Count != other.Other.Count || Other.Exists(locator => !other.Other.Contains(locator))))
			{
				return false;
			}

			return GalileoHostLocator == other.GalileoHostLocator && HostLocator == other.HostLocator && HostSupplier == other.HostSupplier;
		}


		public AdditionalLocatorsDataItem Copy()
		{
			var result = new AdditionalLocatorsDataItem();

			result.GalileoHostLocator = GalileoHostLocator;
			result.HostLocator = HostLocator;
			result.HostSupplier = HostSupplier;

			if (Other != null)
			{
				result.Other = new LocatorList(Other);
			}

			return result;
		}
	}
}