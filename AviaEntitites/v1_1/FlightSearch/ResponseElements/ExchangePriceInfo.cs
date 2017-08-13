using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ExchangePriceInfo
	{
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public Money AirlinePenalty { get; set; }

		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public Money FlightPriceDifference { get; set; }
	}
}