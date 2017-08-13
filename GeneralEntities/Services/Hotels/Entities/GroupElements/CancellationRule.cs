using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class CancellationRule
	{
		public DateTimeEx DeadLine;
		public decimal? PercentValue;
		public Money AbsoluteValue;
	}
}