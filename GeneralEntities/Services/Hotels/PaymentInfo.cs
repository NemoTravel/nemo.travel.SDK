using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralEntities.Services.Hotels.Entities.Booking;

namespace GeneralEntities.Services.Hotels
{
	public class PaymentInfo
	{
		public CreditCard Card;

		public string DiscountCard;

		public Dictionary<PaymentSystem, string> AllowedCardTypes { get; set; }

		public GuaranteeType PaymentType;
	}
}