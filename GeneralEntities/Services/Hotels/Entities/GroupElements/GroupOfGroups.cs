using System.Collections.Generic;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class GroupOfGroups
	{
		public Dictionary<int, RoomTypeGroupElement> RoomTypes;

		public Dictionary<int, RoomMealGroupElement> RoomMeals;

		public Dictionary<int, RoomRateGroupElement> RoomRates;

		public Dictionary<int, CancellationRuleGroupElement> CancellationRules;

		public Dictionary<int, RoomGroupElement> Rooms;
	}
}