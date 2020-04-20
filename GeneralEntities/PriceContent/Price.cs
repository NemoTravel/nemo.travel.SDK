using GeneralEntities.Market;
using System;
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
		public Money TotalPrice { get; private set; }

		/// <summary>
		/// Количество билетов на 1 пассажира, которое будет выписано в рамках данной цены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public int? ExpectedTicketCount { get; set; }

		/// <summary>
		/// Подробности формирования цены
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public PriceBreakdownList PriceBreakdown { get; private set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }

		/// <summary>
		/// Признак поиска с нулевым штрафом возвратности
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool RequestedRefundability { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool ForcedPublicFares { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public FareFamilyDescriptionList FareFamiliesDescriptions { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public SubsidyInformationList SubsidiesInformation { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public FOPPriceList FOPPrices { get; set; }

		/// <summary>
		/// Признак разных семейств на одну литеру
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public bool DifferentFamiliesOnSameClassCode { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public bool FromFareList { get; set; }

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public Money TotalAgencyFare { get; set; }


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
		/// Возвращает коллекцию авиа тарифов, в случае их отсутствия пустой результат.
		/// </summary>
		public IEnumerable<AirTariff> GetAirTariffs()
		{
			var result = new List<AirTariff>();

			foreach (var pricePart in PriceBreakdown)
			{
				if (pricePart != null && pricePart.PassengerTypePriceBreakdown != null)
				{
					foreach (var passType in pricePart.PassengerTypePriceBreakdown)
					{
						result.AddRange(passType.GetAirTariffs());
					}
				}
			}

			return result;
		}

		/// <summary>
		/// Получение тарифа для определённого сегмента услуги, в случае если подобная привязка допустима
		/// </summary>
		/// <param name="segmentID">ИД сегмента в услуге, для которого требуется получить тариф</param>
		/// <returns>Тариф для указанной услуги</returns>
		public BaseTariff GetTariffForSegment(int segmentID)
		{
			var pricePart = PriceBreakdown.Find(pb => pb.IsLinkedToSegment(segmentID));
			if (pricePart != null)
			{
				if (pricePart.PassengerTypePriceBreakdown != null)
				{
					foreach (var passTypePriceBreakdown in pricePart.PassengerTypePriceBreakdown)
					{
						var airTariff = passTypePriceBreakdown.GetTariffForSegment(segmentID);
						if (airTariff != null)
						{
							return airTariff;
						}
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
		public BaseTariff GetTariffForTraveller(int passengerID)
		{
			if (PriceBreakdown.Count > 0)
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
		/// Получение Авиа тарифов для определённого пассажира
		/// </summary>
		/// <param name="travellerID">ID пассажира, чьи тарифы требуется получить</param>
		/// <returns>Тарифы указанного пассажира</returns>
		public IEnumerable<AirTariff> GetAirTariffsForTraveller(int travellerID)
		{
			foreach (var pricePart in PriceBreakdown)
			{
				foreach (var tariff in pricePart.GetAirTariffsForTraveller(travellerID))
				{
					yield return tariff;
				}
			}
		}

		/// <summary>
		/// Получение полной стоимости для одного пассажира
		/// </summary>
		/// <param name="travellerRef">ИД пассажира, для которого требуется получить стоимость</param>
		/// <returns>Стоимость для указанного пассажира. null если нет цена для такого пассажира</returns>
		public Money GetTotalPrice(int travellerRef, int serviceRef)
		{
			return GetPrice(travellerRef, serviceRef, ptpb => ptpb.TotalFare);
		}

		/// <summary>
		/// Получение базовой стоимости для одного пассажира
		/// </summary>
		/// <param name="travellerRef">ИД пассажира, для которого требуется получить стоимость</param>
		/// <returns>Стоимость для указанного пассажира. null если нет цены для такого пассажира</returns>
		public Money GetBasePrice(int travellerRef, int serviceRef)
		{
			return GetPrice(travellerRef, serviceRef, ptpb => ptpb.BaseFare);
		}

		/// <summary>
		/// Получение эквивалентной стоимости для одного пассажира определённого типа
		/// </summary>
		/// <param name="travellerRef">ИД пассажира, для которого требуется получить стоимость</param>
		/// <returns>Стоимость для указанного пассажира. null если нет цены для такого пассажира</returns>
		public Money GetEquivePrice(int travellerRef, int serviceRef)
		{
			return GetPrice(travellerRef, serviceRef, ptpb => ptpb.EquiveFare);
		}

		/// <summary>
		/// Получение всех брекдаунов цен для услуги
		/// </summary>
		/// <param name="serviceID">ИД услуги</param>
		/// <returns>Брекдауны для указанной усулги, пустой массив если ни одного не найдено</returns>
		public List<PriceBreakdown> GetServicePrices(int serviceID)
		{
			return PriceBreakdown.FindAll(pb => pb.IsLinkedToService(serviceID));
		}

		/// <summary>
		/// Проставление полных стоимостей цены и её частей на основании подробностей цены
		/// </summary>
		public void CalculateTotalPrices()
		{
			TotalPrice = new Money();

			foreach (var pricePart in GetPriceBreakdownsForCalculatingTotalPrice())
			{
				pricePart.CalculateTotalPrice();
				TotalPrice += pricePart.TotalPrice;
			}
		}

		/// <summary>
		/// Проставление полных стоимостей цены и её частей на основании подробностей цены с приведением к заданной валюте
		/// </summary>
		public void CalculateTotalPrices(string currency, ICurrencyConverter currencyConverter)
		{
			TotalPrice = new Money(0, currency, currencyConverter);

			foreach (var pricePart in GetPriceBreakdownsForCalculatingTotalPrice())
			{
				pricePart.CalculateTotalPrice();
				TotalPrice += currencyConverter.Convert(pricePart.TotalPrice, currency);
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
				var tariffs = price.PassengerTypePriceBreakdown.SelectMany(pf => pf.GetAirTariffs());
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

			foreach (PriceBreakdown price in PriceBreakdown)
			{
				foreach (AirTariff tariff in price.PassengerTypePriceBreakdown.SelectMany(pf => pf.GetAirTariffs()))
				{
					tariff.FareFamilyDescID = null;
				}
			}
		}


		private bool IsExcluded(PriceBreakdown pricePart, IEnumerable<int> excludedServicesID)
		{
			return excludedServicesID.Any(id => pricePart.IsLinkedToService(id));
		}

		private Money GetPrice(int travellerRef, int serviceRef, Func<PassengerTypePriceBreakdown, Money> selector)
		{
			var breakdowns = PriceBreakdown
				.Where(pb => pb.PassengerTypePriceBreakdown != null && pb.IsLinkedToService(serviceRef))
				.SelectMany(pb => pb.PassengerTypePriceBreakdown)
				.Where(ptpb => ptpb.IsLinkedToTraveller(travellerRef));

			if (breakdowns.Any())
			{
				return breakdowns.Sum(selector);
			}

			return null;
		}

		private IEnumerable<PriceBreakdown> GetPriceBreakdownsForCalculatingTotalPrice()
		{
			return PriceBreakdown.Where(p => !p.IncludedInMainServicePrice);
		}
	}
}