using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class Money
	{
		[XmlAttribute]
		public string Currency { get; set; }

		[XmlAttribute]
		public double Amount { get; set; }

		public static implicit operator Money(GeneralEntities.Market.Money money)
		{
			if (money == null)
			{
				return null;
			}
			return new Money
			{
				Amount = money.Value,
				Currency = money.Currency
			};
		}

		public static Money operator+ (Money a, Money b)
		{
			if (a == null || b == null)
			{
				return null;
			}
			return new Money
			{
				Amount = a.Amount + b.Amount,
				Currency = a.Currency
			};
		}
	}
}
