using GeneralEntities.Pay;
using GeneralEntities.Services.Hotels.Entities.Booking;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Hotels
{
	public class PaymentInfo
	{
		/// <summary>
		/// Нужно, чтобы передать подтверждение 3-DSecure из метода обновления
		/// </summary>
		[IgnoreDataMember]
		public ThreeDSecureConfirmationData PaymentConfirmationData { get; set; }

		public CreditCard Card;

		public string DiscountCard;

		public Dictionary<PaymentSystem, string> AllowedCardTypes { get; set; }

		public GuaranteeType PaymentType;
	}
}