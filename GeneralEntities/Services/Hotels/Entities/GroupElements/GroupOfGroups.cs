using System.Collections.Generic;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class GroupOfGroups
	{
		/// <summary>
		/// Ключ в словаре - RoomTypeGroupElement.Id
		/// </summary>
		public Dictionary<int, RoomTypeGroupElement> RoomTypes;

		/// <summary>
		/// Ключ в словаре - RoomTypeGroupElement.Id
		/// </summary>
		public Dictionary<int, RoomMealGroupElement> RoomMeals;

		/// <summary>
		/// Ключ в словаре - RoomTypeGroupElement.Id
		/// </summary>
		public Dictionary<int, RoomRateGroupElement> RoomRates;

		/// <summary>
		/// Ключ в словаре - RoomTypeGroupElement.Id
		/// </summary>
		public Dictionary<int, CancellationRuleGroupElement> CancellationRules;

		/// <summary>
		/// Ключ в словаре - RoomTypeGroupElement.Id
		/// </summary>
		public Dictionary<int, RoomGroupElement> Rooms;
	}
}