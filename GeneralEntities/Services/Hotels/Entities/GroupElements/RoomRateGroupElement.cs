using GeneralEntities.Market;
using System.Collections.Generic;
using System.Linq;

namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class RoomRateGroupElement
	{
		public int Id;

		public string SupplierId;

		/// <summary>
		/// Нужно в случае, если для проверки доступности и бронирования поставщик отдает разные Id.
		/// Сейчас используется у островка
		/// </summary>
		public string AvailabilityCheckId;

		public Money Price;

		/// <summary>
		/// Нужен для некоторых поставщиков при получении доп.информации о тарифах и подтверждении заказа.
		/// Сейчас используется у тревелпорта, натекнии.
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

		public VATInfo VATInfo;

		public System.DateTime? AgencyTimeLimit;

		public int? FreeCount;

		public RoomRateGroupElement Copy()
		{
			return new RoomRateGroupElement()
			{
				Id = Id,
				SupplierId = SupplierId,
				AvailabilityCheckId = AvailabilityCheckId,
				Price = Price?.Copy(),
				BasePrice = BasePrice?.Copy(),
				IsSpecialOffer = IsSpecialOffer,
				VisaSupportProvided = VisaSupportProvided,
				BookingRemarks = BookingRemarks,
				IsMinPrice = IsMinPrice,
				IsNonRefundable = IsNonRefundable,
				CancellationRuleIds = CancellationRuleIds?.ToList(),
				Provider = Provider,
				PaymentType = PaymentType,
				HoldTimeLimit = HoldTimeLimit,
				IsApproximatePrice = IsApproximatePrice,
				DiscountID = DiscountID,
				PriceAtDay = PriceAtDay,
				NeedAdditionalRequest = NeedAdditionalRequest,
				AdditionalInformation = AdditionalInformation?.ToDictionary(info => info.Key, info => info.Value.ToList()),
				Allotment = Allotment,
				CheckInTime = CheckInTime,
				CheckOutTime = CheckOutTime,
				GuestCitizenshipRequired = GuestCitizenshipRequired,
				Availability = Availability,
				VATInfo = VATInfo?.Copy(),
				AgencyTimeLimit = AgencyTimeLimit,
				FreeCount = FreeCount
			};
		}
	}
}