using GeneralEntities;
using System.Collections.Generic;

namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class Region
	{
		public string Id { get; set; }

		public string Supplier { get; set; }

		public Dictionary<Language, string> Name { get; set; }

		public string CountryId { get; set; }
	}
}
