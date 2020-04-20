namespace GeneralEntities.BookContent.Entities.Booking
{
	public class Guest : Person
	{
		public int? Age { get; set; }

		public HotelsGuestTypes Type { get; set; }
	}
}