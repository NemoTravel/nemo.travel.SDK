using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class CancellationRule
	{
		/// <summary>
		/// Момент, когда правило начинает действовать
		/// </summary>
		public DateTimeEx DeadLine;

		public decimal? PercentValue;

		public Money AbsoluteValue;
	}
}