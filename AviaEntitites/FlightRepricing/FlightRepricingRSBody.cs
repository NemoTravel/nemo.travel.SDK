using AviaEntities.v1_1.FlightSearch.ResponseElements;
using GeneralEntities.PriceContent;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightRepricingRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public FlightList NoServiceLevelDowngrade { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public FlightList BaggageDowngrade { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public SubsidyInformationList SubsidiesInformation { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public RepricingLog Log { get; set; }

		[DataMember(Order = 4)]
		public bool ResultsFiltersApplied { get; set; }
	}
}