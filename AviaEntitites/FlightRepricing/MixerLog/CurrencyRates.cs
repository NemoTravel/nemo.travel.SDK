using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CurrencyRates
	{
		[DataMember(Order = 0)]
		public string TargetCurrency { get; set; }

		[DataMember(Order = 1)]
		public RatesInfo Rates { get; set; }

		public CurrencyRates()
		{
			Rates = new RatesInfo();
		}

		public CurrencyRates(string targetCurrency) : this()
		{
			TargetCurrency = targetCurrency;
		}
	}
}
