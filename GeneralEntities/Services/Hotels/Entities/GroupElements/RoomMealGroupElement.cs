namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class RoomMealGroupElement
	{
		public int Id;

		public string SupplierId;

		public HotelsMealTypes MealCode;

		public string Name;

		public bool IncludedInPrice = false;

		public RoomMealGroupElement Copy()
		{
			return new RoomMealGroupElement()
			{
				Id = Id,
				SupplierId = SupplierId,
				MealCode = MealCode,
				Name = Name,
				IncludedInPrice = IncludedInPrice
			};
		}
	}
}