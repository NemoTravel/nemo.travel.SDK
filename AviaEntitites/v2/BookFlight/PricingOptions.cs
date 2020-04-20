using GeneralEntities.Shared;
using SharedAssembly.Extensions;
using System.Runtime.Serialization;

namespace AviaEntities.v2.BookFlight
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class PricingOptions
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public TypeList<string> FOPsForAlternativePrices { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool NoReprice { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool BookSubsidyTariffs { get; set; }

		public PricingOptions Clone()
		{
			var result = new PricingOptions();

			if (!FOPsForAlternativePrices.IsNullOrEmpty())
			{
				result.FOPsForAlternativePrices = new TypeList<string>(FOPsForAlternativePrices);
			}

			result.NoReprice = NoReprice;

			result.BookSubsidyTariffs = BookSubsidyTariffs;

			return result;
		}
	}
}