using System;
using GeneralEntities.Market;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class PriceBreakdown
	{
		public DateTime? Day;
		public Money Price;

		public PriceBreakdown()
		{
			Price = new Money();
		}
	}
}