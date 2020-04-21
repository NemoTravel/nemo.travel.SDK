using System.Collections.Generic;
using GeneralEntities.BookContent.Entities.GroupElements;

namespace GeneralEntities.Services.Hotels
{
	public class SelectedRoomsData
	{
		public RoomTypeGroupElement RoomType;

		public RoomMealGroupElement RoomMeal;

		public RoomRateGroupElement RoomRate;

		public List<CancellationRuleGroupElement> CancellationRules;

		public RoomGroupElement Room;
	}
}