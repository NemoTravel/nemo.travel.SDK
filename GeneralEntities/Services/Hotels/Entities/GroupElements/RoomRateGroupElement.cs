using GeneralEntities.Market;
using System.Collections.Generic;
using GeneralEntities.Services.Hotels.Entities;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class RoomRateGroupElement
	{
		public int Id;

		public string SupplierId;

		public Money Price;

		/// <summary>
		/// Нужен для Трэвелпорта при получении доп.информации о тарифах
		/// </summary>
		public Money BasePrice;

		public bool IsSpecialOffer = false;

		public bool VisaSupportProvided = false;

		public string BookingRemarks;

		public bool IsMinPrice = false;

		public bool? IsNonRefundable;

		public List<int> CancellationRuleIds;

		public string Provider;

		public GuaranteeType PaymentType;

		public System.DateTime? HoldTimeLimit;

		public bool IsApproximatePrice { get; set; }

		public string DiscountID { get; set; }

		public List<PriceBreakdown> PriceAtDay { get; set; }

		public bool NeedAdditionalRequest { get; set; }

		public Dictionary<string, List<string>> AdditionalInformation { get; set; }

		/// <summary>
		/// Код блока мест покупателя
		/// </summary>
		public string Allotment;

		public string CheckInTime;

		public string CheckOutTime;

		public bool GuestCitizenshipRequired = false;

		public HotelProductAvailability Availability;
	}
}