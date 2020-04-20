using System;
using System.Collections.Generic;
using SharedAssembly.Extensions;

namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class Hotel
	{
		public string Id { get; set; }

		public HotelsSuppliers Supplier { get; set; }

		public Dictionary<Language, string> Name { get; set; }

		/// <summary>
		/// Время в формате HH:mm
		/// </summary>
		public string CheckInTime { get; set; }

		/// <summary>
		/// Время в формате HH:mm
		/// </summary>
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

		public List<string> Phones { get; set; }

		/// <summary>
		/// Создает экземпляр объекта отеля статики. Словари адреса, описания, фич и прочего инициализированы
		/// </summary>
		public Hotel()
		{
			Address = new Dictionary<Language, List<string>>();
			Features = new Dictionary<Language, List<Feature>>();
			Description = new Dictionary<Language, string>();
			Distances = new Dictionary<Language, List<Distance>>();
			Info = new Dictionary<Language, string>();
			CustomerRating = new CustomerRating();
			Phones = new List<string>();
		}

		/// <summary>
		/// Дополняет текущий отель по данным из отеля извне
		/// </summary>
		/// <returns>Успешность объединения</returns>
		public bool TryMerge(Hotel other)
		{
			if (other == null || other.Id != Id || other.Supplier != Supplier)
			{
				return false;
			}

			if (!other.Name.IsNullOrEmpty())
			{
				Name ??= new Dictionary<Language, string>();
				Name.AddRangeWithNonrecurringKey(other.Name);
			}

			if (!other.Info.IsNullOrEmpty())
			{
				Info ??= new Dictionary<Language, string>();
				Info.AddRangeWithNonrecurringKey(other.Info);
			}

			if (!other.Address.IsNullOrEmpty())
			{
				Address ??= new Dictionary<Language, List<string>>();
				Address.AddRangeWithNonrecurringKey(other.Address);
			}

			if (!other.Features.IsNullOrEmpty())
			{
				Features ??= new Dictionary<Language, List<Feature>>();
				Features.AddRangeWithNonrecurringKey(other.Features);
			}

			if (!other.Description.IsNullOrEmpty())
			{
				Description ??= new Dictionary<Language, string>();
				Description.AddRangeWithNonrecurringKey(other.Description);
			}

			if (!other.Distances.IsNullOrEmpty())
			{
				Distances ??= new Dictionary<Language, List<Distance>>();
				Distances.AddRangeWithNonrecurringKey(other.Distances);
			}

			CheckInTime    = string.IsNullOrEmpty(CheckInTime) ? other.CheckInTime : CheckInTime;
			CheckOutTime   = string.IsNullOrEmpty(CheckOutTime) ? other.CheckOutTime : CheckOutTime;
			CityId         = string.IsNullOrEmpty(CityId) ? other.CityId : CityId;
			ResortId       = string.IsNullOrEmpty(ResortId) ? other.ResortId : ResortId;
			HotelChainName = string.IsNullOrEmpty(HotelChainName) ? other.HotelChainName : HotelChainName;

			Photos = Photos.IsNullOrEmpty() ? other.Photos : Photos;
			Phones = Phones.IsNullOrEmpty() ? other.Phones : Phones;

			StarRating     ??= other.StarRating;
			PosLatitude    ??= other.PosLatitude;
			PosLongitude   ??= other.PosLongitude;
			CustomerRating ??= other.CustomerRating;

			return true;
		}

		public bool Equals(Hotel other) =>
			Id == other.Id &&
			Supplier == other.Supplier &&
			Info.ElementsEquals(other.Info);
	}
}
