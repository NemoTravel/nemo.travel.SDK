using AviaEntities.v1_1.FlightSearch.ResponseElements;
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
		public RepricingLog Log { get; set; }
	}
}