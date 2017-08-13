using GeneralEntities.Market;
using GeneralEntities.PriceContent.PricingDebug;
using GeneralEntities.Shared;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Описание составной части цены брони/заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PriceBreakdown
	{
		#region Свойства

		/// <summary>
		/// Ссылка на услугу
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RefList<int> ServiceRef { get; set; }

		/// <summary>
		/// Ссылка на сегмент услуги
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public RefList<int> SegmentRef { get; set; }

		/// <summary>
		/// Полная цена
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public Money TotalPrice { get; set; }

		/// <summary>
		/// ВП
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Признак возвратности по данной цене
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public RefundableEnum Refundable { get; set; }

		/// <summary>
		/// Признак того, что в цене участвуют некие приватные тарифы
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool PrivateFareInd { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string Brand { get; set; }

		/// <summary>
		/// Расклад формирования цены по типам пассажиров
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public PassengerTypePriceBreakdownList PassengerTypePriceBreakdown { get; set; }

		/// <summary>
		/// Информации о рассчитанной цене после ЦО
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public PricingData PricingData { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Money AgencyMarkup { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public Money DiscountByPromoAction { get; set; }

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public bool IsFixed { get; set; }

		[DataMember(Order = 12, EmitDefaultValue = false)]
		public Money RoundingChargePart { get; set; }

		[DataMember(Order = 13, EmitDefaultValue = false)]
		public ChargePartList ChargeBreakdown { get; set; }

		[DataMember(Order = 14, EmitDefaultValue = false)]
		public DebugData PricingDebug { get; set; }

		#endregion

		/// <summary>
		/// Проверяет принадлежность цены определённой услуге
		/// </summary>
		/// <param name="serviceID">ИД услуги, принадлежность к которой требуется проверить</param>
		/// <returns>Принаделжность данной цены к указанной услуге</returns>
		public bool IsLinkedToService(int serviceID)
		{
			return ServiceRef == null || ServiceRef.Contains(serviceID);
		}

		/// <summary>
		/// Проверяет принадлежность цены определённому сегменту в услуге
		/// </summary>
		/// <param name="serviceID">ИД сегмента в услуге, принадлежность к которому требуется проверить</param>
		/// <returns>Принаделжность данной цены к указанному сегменту в услуге</returns>
		public bool IsLinkedToSegment(int segmentID)
		{
			return SegmentRef == null || SegmentRef.Contains(segmentID);
		}

		/// <summary>
		/// Получение имени семейства авиа тарифа для определённого пассажира
		/// </summary>
		/// <param name="travellerID">ID пассажира в брони, для которого нужно получить имя семейства цен</param>
		/// <returns>Имя семейства авиа тарифа</returns>
		public string GetAirTariffFareFamily(int travellerID)
		{
			if (PassengerTypePriceBreakdown != null)
			{
				var passengerPrice = PassengerTypePriceBreakdown.Find(pt => pt.IsLinkedToTraveller(travellerID));
				if (passengerPrice.Tariffs != null && passengerPrice.Tariffs.Count > 0 && passengerPrice.Tariffs[0] is AirTariff)
				{
					return (passengerPrice.Tariffs[0] as AirTariff).FareFamilyCode != null ? (passengerPrice.Tariffs[0] as AirTariff).FareFamilyCode : (passengerPrice.Tariffs[0] as AirTariff).FareFamilyName;
				}
			}

			return null;
		}

		/// <summary>
		/// Вычисление и проставление полных стоимостей цены и её частей на основании подробностей цены
		/// </summary>
		public void CalculateTotalPrice()
		{
			if (PassengerTypePriceBreakdown != null)
			{
				TotalPrice = new Money(PassengerTypePriceBreakdown.Sum(passTypePrice => passTypePrice.TotalFare.Value * passTypePrice.TravellerRef.Count), PassengerTypePriceBreakdown[0].TotalFare.Currency);
			}
			else if (TotalPrice == null)
			{
				TotalPrice = new Money(0, "RUB");
			}
		}
	}
}