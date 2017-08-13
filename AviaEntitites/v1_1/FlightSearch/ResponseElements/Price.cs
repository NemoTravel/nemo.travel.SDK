using GeneralEntities;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using GeneralEntities.PriceContent;
using GeneralEntities.PriceContent.PricingDebug;
using GeneralEntities.Shared;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит всю информацию о цене перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Price_1_1")]
	public class Price : ItemIdentification<int>
	{
		protected DateTimeEx ticketTimeLimit;

		/// <summary>
		/// Валидирующий перевозчик данного перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Индикатор возвратности
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public RefundableEnum Refundable { get; set; }

		/// <summary>
		/// Признак того, что в цене участвуют некие приватные тарифы
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public bool PrivateFareInd { get; set; }

		/// <summary>
		/// Тайм лимит
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public DateTimeEx TicketTimeLimit
		{
			get { return ticketTimeLimit; }
			set
			{
				//проставляем значение в 2х случаях: если нету никакого значения или текущее значение больше проставляемого (тайм-лимит должен быть наименьшим)
				if (ticketTimeLimit == null)
				{
					ticketTimeLimit = value;
				}
				else if (value != null && ticketTimeLimit.DateTime > value.DateTime)
				{
					ticketTimeLimit = value;
				}
			}
		}

		/// <summary>
		/// Бренд(Имя семейства цены)
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string FareFamilyName;

		/// <summary>
		/// Массив цен по типам пассажиров
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public PassengerFareList PassengerFares { get; set; }

		/// <summary>
		/// Опциональные сборы при оплате определёнными типами карт
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public CCTypeFeeList CCTypeFees { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public Money AgencyMarkup { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public Money DicountByPromoAction { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false)]
		public PricingData PricingData { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public Money RoundingChargePart { get; set; }

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public bool IsFixed { get; set; }

		[DataMember(Order = 12, EmitDefaultValue = false)]
		public ChargePartList ChargeBreakdown { get; set; }

		[IgnoreDataMember]
		public Money TotalPrice
		{
			get
			{
				if (PassengerFares != null)
				{
					return new Money(PassengerFares.Sum(pricePart => pricePart.TotalFare.Value * pricePart.Quantity), PassengerFares[0].TotalFare.Currency);
				}
				else
				{
					return null;
				}
			}
		}
	}
}