using System;
using System.Collections.Generic;

namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class Hotel
	{
		public string Id { get; set; }

		public HotelsSuppliers Supplier { get; set; }

		public Dictionary<Language, string> Name { get; set; }

		public string CheckInTime { get; set; }

		public string CheckOutTime { get; set; }

		public int? StarRating { get; set; }

		public string CityId { get; set; }

		public string ResortId { get; set; }

		public double? PosLatitude { get; set; }

		public double? PosLongitude { get; set; }

		public List<string> Photos { get; set; }

		public Dictionary<Language, List<string>> Address { get; set; }

		public Dictionary<Language, List<Feature>> Features { get; set; }

		public Dictionary<Language, string> Description { get; set; }

		public DateTime? LastUpdated { get; set; }

		public Dictionary<Language, List<Distance>> Distances { get; set; }

		public CustomerRating CustomerRating { get; set; }

		public Dictionary<Language, string> Info { get; set; }

		public bool Deleted { get; set; }

		public bool IsShore { get; set; }

		public string HotelChainName { get; set; }
	}
}
