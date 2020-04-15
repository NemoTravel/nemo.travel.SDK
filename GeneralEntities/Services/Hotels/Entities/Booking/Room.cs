using GeneralEntities.Market;
using System.Collections.Generic;
using GeneralEntities.BookContent.Entities.GroupElements;
using GeneralEntities.Services.Hotels.Entities.Booking;

namespace GeneralEntities.BookContent.Entities.Booking
{
	public class Room
	{
		public int RoomId;

		public List<int> GuestsIds;

		public int AdultsCount;

		public int ChildrenCount;

		public int SearchIndex;

		public string SupplierReference;

		public string SupplierRateId;

		public string SupplierTypeId;

		public long SupplierProductId;

		public string type;

		public string SupplierMealId;

		public string meal;

		public HotelsMealTypes? MealCode;

		public Money Price;

		public VATInfo VATInfo;

		public bool IsApproximate { get; set; }

		public string DiscountId { get; set; }

		public List<PriceBreakdown> PriceBreakdown { get; set; }

		/// <summary>
		/// Дополнительная информация о тарифе
		/// </summary>
		public Dictionary<string, List<string>> AdditionalInformation { get; set; }

		public bool IsSpecialOffer;

		public bool VisaSupportProvided;

		public string BookingRemarks;

		public bool? IsNonRefundable;

		public System.DateTime? HoldTimeLimit;

		/// <summary>
		/// Код блока мест покупателя
		/// </summary>
		public string Allotment;

		public string CheckInTime;

		public string CheckOutTime;

		public bool MealIncludedInPrice;

		/// <summary>
		/// Комментарий заказчика
		/// </summary>
		public string AdditionalInfo;

		public HotelProductAvailability Availability;

		public CheckInCheckOutService EarlyCheckInService;

		public CheckInCheckOutService LateCheckOutService;
	}
}