using GeneralEntities;
using System.Collections.Generic;

namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class City
	{
		public string Id { get; set; }

		public string Supplier { get; set; }

		public Dictionary<Language,string> Name { get; set; }

		public string CountryId { get; set; }

		public string RegionId { get; set; }

		public string Iata { get; set; }

		public double? Latitude { get; set; }

		public double? Longitude { get; set; }
	}
}
