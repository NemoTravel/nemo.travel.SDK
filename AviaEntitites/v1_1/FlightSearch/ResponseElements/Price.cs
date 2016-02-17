using GeneralEntities;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.PriceContent;
using GeneralEntities.Shared;
using System.Collections.Generic;
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
		/// Массив цен по типам пассажиров
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public PassengerFareList PassengerFares { get; set; }

		/// <summary>
		/// Опциональные сборы при оплате определёнными типами карт
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public CCTypeFeeList CCTypeFees { get; set; }
	}
}