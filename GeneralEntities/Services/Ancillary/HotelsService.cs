using GeneralEntities.BookContent.Entities.Booking;
using GeneralEntities.BookContent.Entities.GroupElements;
using GeneralEntities.Services.Hotels.Entities.GroupElements.Static;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeneralEntities.Services.Ancillary
{
	public class HotelsService : BaseService
	{
		public const string BOOKED_ROOM = "BOOKED_ROOM";

		const string SERVICE_PARAM_SEARCH_ID = "search_id";

		public const string SERVICE_PARAM_ACCOMODATION_ID = "accomodation_id";

		/// <summary>
		/// Название поставщика
		/// </summary>
		public HotelsSuppliers Supplier;

		public int PackageId;

		public HotelsBookStatus BookingStatus;

		public string HotelId;

		public string CityId;

		public long SearchId;

		public DateTime CheckInDate;

		public DateTime CheckOutDate;

		public List<Room> Rooms;

		public Person Client;

		public List<CancellationRuleGroupElement> CancellationRules { get; set; }

		public StaticDataContainer StaticDataContainer { get; set; }

		public Hotels.PaymentInfo PaymentInfo;

		public Hotels.ServiceParams ServiceParams;

		public void SetServiceParam<T>(string key, T value)
		{
			ServiceParams.Params[key] = JsonConvert.SerializeObject(value);
		}

		public T GetServiceParam<T>(string key)
		{
			if (ServiceParams.Params.ContainsKey(key))
			{
				return JsonConvert.DeserializeObject<T>(ServiceParams.Params[key]);
			}
			return default(T);
		}
	}
}