using GeneralEntities.Market;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.FareRulesInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ExchangeData : ICloneable
	{
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public FareRuleApplicationCondition Exchangeable { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Money Charge { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public ConditionsList Prohibitions { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as ExchangeData;
			if (other == null)
			{
				return false;
			}

			return Exchangeable == other.Exchangeable && Equals(Charge, other.Charge) && Equals(Prohibitions, other.Prohibitions);
		}

		public object Clone()
		{
			var result = new ExchangeData();

			result.Exchangeable = Exchangeable;
			result.Charge = Charge?.Copy();

			if (Prohibitions != null)
			{
				result.Prohibitions = new ConditionsList(Prohibitions);
			}

			return result;
		}
	}
}