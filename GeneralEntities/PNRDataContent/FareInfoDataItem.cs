using GeneralEntities.PNRDataContent.Ancillary.FareRulesInfo;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Различная информация распарсенная из тарифных правил
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FareInfoDataItem
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public TimeBasedFareRule<RefundData> Refunds { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public TimeBasedFareRule<ExchangeData> Exchanges { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as FareInfoDataItem;
			if (other == null)
			{
				return false;
			}

			return Equals(Refunds, other.Refunds) && Equals(Exchanges, other.Exchanges);
		}

		public FareInfoDataItem Copy()
		{
			var result = new FareInfoDataItem();

			result.Refunds = Refunds?.Copy();
			result.Exchanges = Exchanges?.Copy();

			return result;
		}
	}
}