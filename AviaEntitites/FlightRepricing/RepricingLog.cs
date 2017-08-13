using AviaEntities.FlightRepricing.MixerLog;
using GeneralEntities.PriceContent.PricingDebug;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RepricingLog
	{
		[DataMember(Order = 0)]
		public bool Enabled { get; set; }

		[DataMember(Order = 1)]
		public bool HasRules { get; set; }

		[DataMember(Order = 2)]
		public int FlightSource { get; set; }

		[DataMember(Order = 3)]
		public int AppliedRuleID { get; set; }

		[DataMember(Order = 4)]
		public int AppliedAirlineRuleID { get; set; }

		[DataMember(Order = 5)]
		public string ValidatingCompany { get; set; }

		[DataMember(Order = 6)]
		public IDList<int> TargetSources { get; set; }

		[DataMember(Order = 7)]
		public SourceResultInfo PricingResults { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public AvailabilityCheckInfo AvailabilityCheckFailures { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false)]
		public AviaMixerLog MixerLog { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public PricingDebugDataCollection PricingDebugLogs { get; set; }

		public RepricingLog()
		{
			AppliedRuleID = -1;
			AppliedAirlineRuleID = -1;
			TargetSources = new IDList<int>();
			PricingResults = new SourceResultInfo();
		}
	}
}