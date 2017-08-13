using GeneralEntities.Market;
using System.Collections.Generic;
using GeneralEntities.BookContent.Entities.GroupElements;

namespace GeneralEntities.BookContent.Entities.Booking
{
	public class Room
	{
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

		public Money Price;

		public bool IsApproximate { get; set; }

		public string DiscountId { get; set; }

		public List<PriceBreakdown> PriceBreakdown { get; set; }

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

		public string AdditionalInfo;

		public HotelProductAvailability Availability;
	}
}