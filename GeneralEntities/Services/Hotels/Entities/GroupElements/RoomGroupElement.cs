using GeneralEntities.Market;
using System.Collections.Generic;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class RoomGroupElement
	{
		public int Id;
		public int? TypeId;

		public int RateId;
		public int? MealId;
		public List<Money> MarkUps = new List<Money>();
	}
}