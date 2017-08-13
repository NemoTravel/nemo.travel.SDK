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
		[DataMember(Order = 2)]
		public int RuleID { get; set; }

		public ChargePart() { }

		public ChargePart(int ruleID, Money money)
		{
			RuleID = ruleID;
			Value = money.Value;
			Currency = money.Currency;
		}
	}
}