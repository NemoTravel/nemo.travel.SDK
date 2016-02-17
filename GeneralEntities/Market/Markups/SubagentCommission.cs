using System.Runtime.Serialization;

namespace GeneralEntities.Market.Markups
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class SubagentCommission : Modificants
	{
		public SubagentCommission()
		{
		}

		public SubagentCommission(Modificants modificants)
		{
			Value = modificants.Value;
			RelativeValue = modificants.RelativeValue;
			Currency = modificants.Currency;
			CurrencyConverter = modificants.CurrencyConverter;
		}
	}
}
