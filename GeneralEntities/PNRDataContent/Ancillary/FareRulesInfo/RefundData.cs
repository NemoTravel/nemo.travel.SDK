using GeneralEntities.Market;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.FareRulesInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class RefundData : ICloneable
	{
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public FareRuleApplicationCondition RefundableTarrif { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Money Charge { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public ConditionsList Prohibitions { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public ConditionsList Notes { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public ConditionsList FullRefundAllowances { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as RefundData;
			if (other == null)
			{
				return false;
			}

			return RefundableTarrif == other.RefundableTarrif && Equals(Charge, other.Charge) && Equals(Prohibitions, other.Prohibitions) &&
				Equals(Notes, other.Notes) && Equals(FullRefundAllowances, other.FullRefundAllowances);
		}

		public object Clone()
		{
			var result = new RefundData();

			result.RefundableTarrif = RefundableTarrif;
			result.Charge = Charge?.Copy();

			if (Prohibitions != null)
			{
				result.Prohibitions = new ConditionsList(Prohibitions);
			}

			if (Notes != null)
			{
				result.Notes = new ConditionsList(Notes);
			}

			if (FullRefundAllowances != null)
			{
				result.FullRefundAllowances = new ConditionsList(FullRefundAllowances);
			}

			return result;
		}
	}
}