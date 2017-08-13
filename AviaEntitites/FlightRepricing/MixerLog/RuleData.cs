using System.Runtime.Serialization;
using System.Text;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RuleData
	{
		[DataMember(Order = 1)]
		public AviaMixerPriceCondition FirstPriceCondition { get; set; }

		[DataMember(Order = 2)]
		public AviaMixerPriceCondition SecondPriceCondition { get; set; }

		[DataMember(Order = 3)]
		public SourceList Sources { get; set; }

		internal string Dump()
		{
			var logBuilder = new StringBuilder();

			logBuilder.
				Append(FirstPriceCondition.ToString()).
				Append(';').
				Append(SecondPriceCondition.ToString()).
				Append(';').
				Append(string.Join(", ", Sources)).
				Append(';');

			return logBuilder.ToString();
		}
	}
}