using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ChargePart : Money
	{
		/// <summary>
		/// Номер правила, по которому был рассчитан сбор
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? RuleID { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public ChargeType? Type { get; set; }


		public ChargePart()
		{
		}

		public ChargePart(Money money, int ruleID)
			: base(money)
		{
			RuleID = ruleID;
		}

		public ChargePart(Money money, ChargeType type)
			: base(money)
		{
			Type = type;
		}

		public ChargePart(Money money, ChargeType type, int ruleID)
			: base(money)
		{
			RuleID = ruleID;
			Type = type;
		}

		public ChargePart(ChargePart other)
			: base(other)
		{
			RuleID = other.RuleID;
			Type = other.Type;
		}


		public new ChargePart Copy()
		{
			return new ChargePart(this);
		}
	}
}