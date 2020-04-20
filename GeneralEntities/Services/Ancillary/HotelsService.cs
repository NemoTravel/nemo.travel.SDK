using GeneralEntities.BookContent.Entities.Booking;
using GeneralEntities.BookContent.Entities.GroupElements;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using GeneralEntities.Services.Hotels;
using GeneralEntities.Services.Hotels.Entities.GroupElements.Static;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeneralEntities.Services.Ancillary
{
	public class HotelsService : BaseService
	{
		/// <summary>
		/// Название поставщика
		/// </summary>
		public HotelsSuppliers Supplier { get; set; }

		public string SupplierAgencyID { get; set; }

		public int PackageId { get; set; }

		public HotelsBookStatus BookingStatus { get; set; }

		public string HotelId { get; set; }

		public string CityId { get; set; }

		public long SearchId { get; set; }

		public DateTimeEx CheckInDate { get; set; }

		public string CheckInTime { get; set; }

		public DateTimeEx CheckOutDate { get; set; }

		public string CheckOutTime { get; set; }

		public Dictionary<int, SelectedRoomsData> SelectedRoomsData { get; set; }

		public List<Room> Rooms { get; set; }

		public Person Client { get; set; }

		public List<CancellationRuleGroupElement> CancellationRules { get; set; }

		public StaticDataContainer StaticDataContainer { get; set; }

		public PaymentInfo PaymentInfo { get; set; }

		public ServiceParams ServiceParams { get; set; }

		public Money CancellationPenalty { get; set; }

		public DateTime SearchDateTime { get; set; }

		public void SetServiceParam<T>(string key, T value)
		{
			ServiceParams.Params[key] = JsonConvert.SerializeObject(value);
		}

		public T GetServiceParam<T>(string key)
		{
			if (ServiceParams.Params.TryGetValue(key, out string param))
			{
				return JsonConvert.DeserializeObject<T>(param);
			}

			return default;
		}
	}
}