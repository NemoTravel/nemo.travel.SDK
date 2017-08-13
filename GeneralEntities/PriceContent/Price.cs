using GeneralEntities.Market;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
		/// Количество билетов на 1 пассажира, которое будет выписано в рамках данной цены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public int? ExpectedTicketCount { get; set; }

		/// <summary>
		/// Подробности формирования цены
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public PriceBreakdownList PriceBreakdown { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }

		/// <summary>
		/// Признак поиска с нулевым штрафом возвратности
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool RequestedRefundability { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool ForcedPublicFares { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public FareFamilyDescriptionList FareFamiliesDescriptions { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public FOPPriceList FOPPrices { get; set; }


		public Price()
		{
			PriceBreakdown = new PriceBreakdownList();
		}

		/// <summary>
		/// Получение авиа тарифа для определённого сегмента перелёта, в случае если подобная привязка допустима
		/// </summary>
		/// <param name="segmentID">ИД сегмента в услуге, для которого требуется получить тариф</param>
		/// <returns>Тариф для указанной услуги</returns>
		public AirTariff GetAirTariffForSegment(int segmentID)
		{
			return GetTariffForSegment(segmentID) as AirTariff;
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
		/// Получение тарифа для определённого пассажира из брони
		/// </summary>
		/// <param name="passengerID">ИД пассажира в брони, для которого требуется получить тариф</param>
		/// <returns>Тариф для указанного пассажира</returns>
		public BaseTariff GetTariffForPassenger(int passengerID)
		{
			if (PriceBreakdown != null && PriceBreakdown.Count > 0)
			{
				var pricePart = PriceBreakdown.Find(pb => pb.PassengerTypePriceBreakdown != null && pb.PassengerTypePriceBreakdown.Any(ptc => ptc.IsLinkedToTraveller(passengerID)));
				if (pricePart != null)
				{
					return pricePart.PassengerTypePriceBreakdown.Find(ptc => ptc.IsLinkedToTraveller(passengerID)).Tariffs[0];
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
		/// <returns>Стоимость для указанного пассажира. null если нет цены для такого пассажира</returns>
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
		/// Получение эквивалентной стоимости для 1 пассажира определённого типа
		/// </summary>
		/// <param name="passengerID">ИД пассажира, для которого требуется получить стоимость</param>
		/// <returns>Стоимость для указанного пассажира. null если нет цены для такого пассажира</returns>
		public Money GetEquivePrice(int passengerID)
		{
			if (PriceBreakdown != null && PriceBreakdown.Any(pi => pi.PassengerTypePriceBreakdown != null && pi.PassengerTypePriceBreakdown.Any(pf => pf.IsLinkedToTraveller(passengerID))))
			{
				Money result = null;
				foreach (var price in PriceBreakdown.FindAll(pb => pb.PassengerTypePriceBreakdown != null && pb.PassengerTypePriceBreakdown.Any(pf => pf.IsLinkedToTraveller(passengerID))))
				{
					var passTypePrice = price.PassengerTypePriceBreakdown.Find(pf => pf.IsLinkedToTraveller(passengerID));
					if (result == null)
					{
						result = passTypePrice.EquiveFare;
					}
					else
					{
						result += passTypePrice.EquiveFare;
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
		/// Получение всех брекдаунов цен для услуги
		/// </summary>
		/// <param name="serviceID">ИД услуги</param>
		/// <returns>Брекдауны для указанной усулги, пустой массив если ни одного не найдено</returns>
		public List<PriceBreakdown> GetServicePrice(int serviceID)
		{
			return PriceBreakdown.FindAll(pb => pb.IsLinkedToService(serviceID));
		}

		/// <summary>
		/// Вычисление и проставление полных стоимостей цены и её частей на основании подробностей цены
		/// </summary>
		/// <param name="excludedServicesID">ИД услуг, которые необходимо исключить из полной стоимости</param>
		public void CalculateTotalPrices(params int[] excludedServicesID)
		{
			if (PriceBreakdown != null)
			{
				foreach (var pricePart in PriceBreakdown)
				{
					if (!IsExcluded(pricePart, excludedServicesID))
					{
						pricePart.CalculateTotalPrice();
					}
				}

				TotalPrice = new Money(
					PriceBreakdown.FindAll(pb => !IsExcluded(pb, excludedServicesID)).Sum(pb => pb.TotalPrice.Value),
					PriceBreakdown[0].TotalPrice.Currency);
			}
		}

		public string GetFareFamiliesNames()
		{
			if ((FareFamiliesDescriptions == null || !FareFamiliesDescriptions.Any()) || 
				(PriceBreakdown == null || !PriceBreakdown.Any()))
			{
				return null;
			}

			var result = new StringBuilder();
			foreach (var price in PriceBreakdown)
			{
				var tariffs = price.PassengerTypePriceBreakdown.SelectMany(pf => pf.Tariffs).Cast<AirTariff>();
				foreach (var tariff in tariffs)
				{
					var ffDescr = FareFamiliesDescriptions.Find(d => d.ID == tariff.FareFamilyDescID);
					if (ffDescr != null)
					{
						result.Append(ffDescr.Name);
					}
					result.Append(';');
				}
			}

			return result.ToString();
		}

		public void CleanFareFamiliesData()
		{
			FareFamiliesDescriptions = null;

			foreach (var price in PriceBreakdown)
			{
				foreach (var tariff in price.PassengerTypePriceBreakdown.SelectMany(pf => pf.Tariffs))
				{
					((AirTariff)tariff).FareFamilyDescID = null;
				}
			}
		}


		private bool IsExcluded(PriceBreakdown pricePart, int[] excludedServicesID)
		{
			return excludedServicesID != null && excludedServicesID.Any(id => pricePart.IsLinkedToService(id));
		}
	}
}