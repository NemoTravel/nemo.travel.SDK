using GeneralEntities;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class RoomMealGroupElement
	{
		public int Id;

		public string SupplierId;

		public HotelsMealTypes MealCode;

		public string Name;

		public bool IncludedInPrice = false;
	}
}