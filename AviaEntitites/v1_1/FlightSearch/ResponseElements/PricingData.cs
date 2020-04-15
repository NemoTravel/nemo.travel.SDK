using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class PricingData
	{
		[DataMember(Order = 0)]
		public int PricingRule { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Code { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Commission AirlineCommission { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public Commission AgencyProfit { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string TicketDesignator { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string Endorsment { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string TourCode { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string Discount { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public Money AgencyCommission { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Money Bonus { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public string AuthCode { get; set; }

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public string AcquiringMode { get; set; }

		[DataMember(Order = 12, EmitDefaultValue = false)]
		public bool AutoticketingDisabled { get; set; }
	}
}
