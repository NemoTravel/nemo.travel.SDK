using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType()]
	public class Price
	{
		[XmlText]
		public double Amount { get; set; }

		[XmlAttribute]
		public string Currency { get; set; }

		public static implicit operator Price(GeneralEntities.Market.Money money)
		{
			if (money == null)
			{
				return null;
			}

			return new Price
			{
				Amount = money.Value,
				Currency = money.Currency
			};
		}
	}
}
