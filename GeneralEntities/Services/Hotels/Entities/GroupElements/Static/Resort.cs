using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class Resort
	{
		public long Id { get; set; }

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

		public string Name { get; set; }

		public long CityId { get; set; }
	}
}
