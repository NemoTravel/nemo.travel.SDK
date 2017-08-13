using System.Runtime.Serialization;
using System.Text;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AviaMixerLog
	{
		[DataMember(Order = 0)]
		public bool Enabled { get; set; }

		[DataMember(Order = 1)]
		public int TotalFlightsCount { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? MixedFlightsCount { get; set; }

		[DataMember(Order = 3)]
		public int MixingRulesCount { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public MixResults MixResults { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public RulesCollection MixingRules { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public CurrencyRates CurrencyRates { get; set; }

		public string Dump()
		{
			var logBuilder = new StringBuilder();

			logBuilder.Append("Mixer enabled: ").Append(Enabled).AppendLine();
			logBuilder.Append("Total flights count: ").Append(TotalFlightsCount).AppendLine();
			logBuilder.Append("Mixing rules count: ").Append(MixingRulesCount).AppendLine();

			if (MixedFlightsCount.HasValue)
			{
				logBuilder.Append("Mixed flights count: ").Append(MixedFlightsCount).AppendLine();
			}

			if (MixResults != null && MixResults.Count > 0)
			{
				logBuilder
					.AppendLine().
					AppendLine("Group ID;Mixing rule ID;Airline;Mixing code;Minimal GDS price;Minimal price;Maximal price;Maximal charge;Maximal commission;Maximal profit;Package ID;Passed levels;Is result;Original price");
				foreach (var mixResult in MixResults)
				{
					logBuilder.Append(mixResult.Dump());
				}
			}

			if (MixingRulesCount > 0)
			{
				logBuilder.
					AppendLine().
					AppendLine("Mixing rules").
					AppendLine("Rule ID;First price condition;Second price condition;Sources");
				foreach (var rule in MixingRules)
				{
					logBuilder.Append(rule.Key).Append(';').AppendLine(rule.Value.Dump());
				}
			}

			if (CurrencyRates != null)
			{
				logBuilder.
					AppendLine().
					AppendLine("Currency rates").
					Append("Result currency: ").
					AppendLine(CurrencyRates.TargetCurrency).
					AppendLine("Currency;Rate");
				foreach(var rate in CurrencyRates.Rates)
				{
					logBuilder.Append(rate.Key).Append(';').Append(rate.Value).Append(';').AppendLine();
				}
			}

			return logBuilder.ToString().TrimEnd();
		}
	}
}