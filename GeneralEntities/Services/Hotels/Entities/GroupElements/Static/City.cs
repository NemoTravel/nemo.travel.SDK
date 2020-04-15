using GeneralEntities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class City
	{
		public string Id { get; set; }

		[JsonIgnore]
		[IgnoreDataMember]
		public HotelsSuppliers Supplier { get; set; }

		[JsonProperty("Supplier")]
		[DataMember(Name = "Supplier")]
		public string SupplierString
		{
			get
			{
				return Supplier.ToString();
			}
			set
			{
				Supplier = EnumUtils.ParseEnumFromString<HotelsSuppliers>(value);
			}
		}

		public Dictionary<Language,string> Name { get; set; }

		public string CountryId { get; set; }

		public string RegionId { get; set; }

		public string Iata { get; set; }

		public double? Latitude { get; set; }

		public double? Longitude { get; set; }
	}
}
