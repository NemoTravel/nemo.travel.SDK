using GeneralEntities.Market;
using System.Runtime.Serialization;
using System;
using System.Text;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightMixData
	{
		[DataMember(Order = 0)]
		public Money MinimalGDSPrice { get; set; }

		[DataMember(Order = 1)]
		public Money MinimalPrice { get; set; }

		[DataMember(Order = 2)]
		public Money MaximalPrice { get; set; }

		[DataMember(Order = 3)]
		public Money MaximalCharge { get; set; }

		[DataMember(Order = 4)]
		public Money MaximalCommission { get; set; }

		[DataMember(Order = 5)]
		public Money MaximalProfit { get; set; }

		[DataMember(Order = 6)]
		public int Package { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public PassedLevelsList PassedLevels { get; set; }

		[DataMember(Order = 8)]
		public bool IsResult { get; set; }

		[DataMember(Order = 9)]
		public Money OriginalPrice { get; set; }

		[DataMember(Order = 10)]
		public string FlightID { get; set; }

		internal string Dump()
		{
			var logBuilder = new StringBuilder();

			logBuilder.
				Append(MinimalGDSPrice).
				Append(';').
				Append(MinimalPrice).
				Append(';').
				Append(MaximalPrice).
				Append(';').
				Append(MaximalCharge).
				Append(';').
				Append(MaximalCommission).
				Append(';').
				Append(MaximalProfit).
				Append(';').
				Append(Package).
				Append(';').
				Append(PassedLevels != null ? string.Join(", ", PassedLevels) : null).
				Append(';').
				Append(IsResult ? '+' : '-').
				Append(';').
				Append(OriginalPrice).
				Append(';');

			return logBuilder.ToString();
		}
	}
}