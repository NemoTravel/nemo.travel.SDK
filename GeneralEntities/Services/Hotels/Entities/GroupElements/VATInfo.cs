using GeneralEntities.Market;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class VATInfo
	{
		public Money Amount { get; set; }

		public bool FromFullPrice { get; set; }

		public bool IncludeInPrice { get; set; }

		public float? VatPercent { get; set; }

		public VATInfo()
		{
			Amount = new Money();
		}

		public VATInfo Copy()
		{
			return new VATInfo()
			{
				Amount = Amount.Copy(),
				FromFullPrice = FromFullPrice,
				IncludeInPrice = IncludeInPrice,
				VatPercent = VatPercent,
			};
		}
	}
}