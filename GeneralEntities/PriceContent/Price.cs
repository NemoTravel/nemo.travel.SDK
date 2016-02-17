using GeneralEntities.Market;
using System.Runtime.Serialization;
using System.Linq;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Цена брони/заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Price
	{
		/// <summary>
		/// Полная цена
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public Money TotalPrice { get; set; }

		/// <summary>
		/// Подробности формирования цены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PriceBreakdownList PriceBreakdown { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }

		public Price()
		{
			PriceBreakdown = new PriceBreakdownList();
		}

		/// <summary>
		/// Получение тарифа для определённого сегмента услуги, в случае если подобная привязка допустима
		/// </summary>
		/// <param name="segmentID">ИД сегмента в услуге, для которого требуется получить тариф</param>
		/// <returns>Тариф для указанной услуги</returns>
		public BaseTariff GetTariffForSegment(int segmentID)
		{
			if (PriceBreakdown != null && PriceBreakdown.Count > 0)
			{
				var pricePart = PriceBreakdown.Find(pb => pb.IsLinkedToSegment(segmentID));
				if (pricePart != null)
				{
					if (pricePart.PassengerTypePriceBreakdown != null && pricePart.PassengerTypePriceBreakdown.Count > 0)
					{
						return pricePart.PassengerTypePriceBreakdown[0].GetTariffForSegment(segmentID);
					}
				}
			}

			return null;
		}

		/// <summary>
		/// Получение стоимости для 1 пассажира определённого типа
		/// </summary>
		/// <param name="passengerID">ИД пассажира, для которого требуется получить стоимость</param>
		/// <returns>Стоимость для указанного пассажира. null если нет цена для такого пассажира</returns>
		public Money GetPrice(int passengerID)
		{
			if (PriceBreakdown != null && PriceBreakdown.Any(pi => pi.PassengerTypePriceBreakdown != null && pi.PassengerTypePriceBreakdown.Any(pf => pf.IsLinkedToTraveller(passengerID))))
			{
				Money result = null;
				foreach (var price in PriceBreakdown.FindAll(pb => pb.PassengerTypePriceBreakdown != null && pb.PassengerTypePriceBreakdown.Any(pf => pf.IsLinkedToTraveller(passengerID))))
				{
					var passTypePrice = price.PassengerTypePriceBreakdown.Find(pf => pf.IsLinkedToTraveller(passengerID));
					if (result == null)
					{
						result = passTypePrice.TotalFare;
					}
					else
					{
						result += passTypePrice.TotalFare;
					}
				}
				return result;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Получение базовой стоимости для 1 пассажира определённого типа
		/// </summary>
		/// <param name="passengerID">ИД пассажира, для которого требуется получить стоимость</param>
		/// <returns>Стоимость для указанного пассажира. null если нет цена для такого пассажира</returns>
		public Money GetBasePrice(int passengerID)
		{
			if (PriceBreakdown != null && PriceBreakdown.Any(pi => pi.PassengerTypePriceBreakdown != null && pi.PassengerTypePriceBreakdown.Any(pf => pf.IsLinkedToTraveller(passengerID))))
			{
				Money result = null;
				foreach (var price in PriceBreakdown.FindAll(pb => pb.PassengerTypePriceBreakdown != null && pb.PassengerTypePriceBreakdown.Any(pf => pf.IsLinkedToTraveller(passengerID))))
				{
					var passTypePrice = price.PassengerTypePriceBreakdown.Find(pf => pf.IsLinkedToTraveller(passengerID));
					if (result == null)
					{
						result = passTypePrice.BaseFare;
					}
					else
					{
						result += passTypePrice.BaseFare;
					}
				}
				return result;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Вычисление и проставление полных стоимостей цены и её частей на основании подробностей цены
		/// </summary>
		public void CalculateTotalPrices()
		{
			if (TotalPrice == null && PriceBreakdown != null)
			{
				foreach (var pricePart in PriceBreakdown)
				{
					if (pricePart.TotalPrice == null && pricePart.PassengerTypePriceBreakdown != null)
					{
						pricePart.TotalPrice = new Money(pricePart.PassengerTypePriceBreakdown.Sum(passTypePrice => passTypePrice.TotalFare.Value * passTypePrice.TravellerRef.Count), pricePart.PassengerTypePriceBreakdown[0].TotalFare.Currency);
					}
				}

				TotalPrice = new Money(PriceBreakdown.Sum(pricePart => pricePart.TotalPrice.Value), PriceBreakdown[0].TotalPrice.Currency);
			}
		}
	}
}