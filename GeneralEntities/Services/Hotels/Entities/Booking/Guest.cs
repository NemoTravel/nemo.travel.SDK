using GeneralEntities;
using GeneralEntities.Market;
using System.Collections.Generic;

namespace GeneralEntities.BookContent.Entities.Booking
{
	public class Guest : Person
	{
		public int? Age;
		public HotelsGuestTypes Type;
	}
}