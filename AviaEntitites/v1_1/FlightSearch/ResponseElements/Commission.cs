using GeneralEntities;
using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Commission
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public Money Money { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public double? Percent { get; set; }

		[DataMember(Order = 2)]
		public CommissionType Type { get; set; }
	}
}
