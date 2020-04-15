using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Содержит описание составляющей части цены на определённый тип пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PassengerTypePriceBreakdown
	{
		/// <summary>
		/// Ссылка на пассажиров в брони/заказе
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RefList<int> TravellerRef { get; set; }

		/// <summary>
		/// Тип пассажира прайсинга
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string PricingType { get; set; }

		/// <summary>
		/// Цена в базовой валюте
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Money BaseFare { get; set; }

		/// <summary>
		/// Цена в эквивалентной валюте
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public Money EquiveFare
		{
			get
			{
				if (equiveFare == null)
				{
					if (TotalFare != null && BaseFare != null && TotalFare.Currency == BaseFare.Currency)
					{
						return BaseFare;
					}

					return null;
				}

				return equiveFare;
			}
			set
			{
				equiveFare = value;
			}
		}

		/// <summary>
		/// Суммарная цена для 1 пассажира данного типа
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public Money TotalFare { get; set; }

		/// <summary>
		/// Таксы
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public TaxList Taxes { get; set; }

		/// <summary>
		/// Тарифы
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public TariffList Tariffs { get; set; }

		/// <summary>
		/// Строка рассчёта цены
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string FareCalc { get; set; }

		/// <summary>
		/// Сбор
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public Money Markup { get; set; }

		/// <summary>
		/// EquiveFare в валюте агентства
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Money AgencyFare { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public Money TotalAgencyFare { get; set; }

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public ChargePartList ChargeBreakdown { get; set; }

		[DataMember(Order = 12, EmitDefaultValue = false)]
		public Money MarkupRound { get; set; }

		/// <summary>
		/// Получение тарифа для определённого сегмента услуги, в случае если подобная привязка допустима
		/// </summary>
		/// <param name="segmentID">ИД сегмента в услуге, для которого требуется получить тариф</param>
		/// <returns>Тариф для указанной услуги</returns>
		public BaseTariff GetTariffForSegment(int segmentID)
		{
			foreach (var tariff in Tariffs)
			{
				var airTariff = tariff as AirTariff;

				if (airTariff != null && airTariff.SegmentID == segmentID)
				{
					return tariff;
				}
			}

			return null;
		}

		/// <summary>
		/// Выполняет проверку привязки данной цены к определённому пассажиру
		/// </summary>
		/// <param name="travellerID">ИД пассажира</param>
		/// <returns>Признак привязки указанного пассажира к данной цене</returns>
		public bool IsLinkedToTraveller(int travellerID)
		{
			return TravellerRef != null && TravellerRef.Contains(travellerID);
		}

		public IReadOnlyList<AirTariff> GetAirTariffs()
		{
			if (Tariffs == null)
			{
				return new List<AirTariff>();
			}

			return Tariffs.OfType<AirTariff>().ToList();
		}

		public PassengerTypePriceBreakdown Copy()
		{
			var result = new PassengerTypePriceBreakdown();

			result.PricingType = this.PricingType;
			result.FareCalc = this.FareCalc;
			result.AgencyFare = this.AgencyFare?.Copy();
			result.BaseFare = this.BaseFare?.Copy();
			result.EquiveFare = this.EquiveFare?.Copy();
			result.TotalFare = this.TotalFare?.Copy();
			result.Markup = this.Markup?.Copy();
			result.MarkupRound = this.MarkupRound?.Copy();
			result.TotalAgencyFare = this.TotalAgencyFare?.Copy();

			if (this.ChargeBreakdown != null)
			{
				result.ChargeBreakdown = new ChargePartList();

				foreach (var chargePart in this.ChargeBreakdown)
				{
					result.ChargeBreakdown.Add(chargePart.Copy());
				}
			}

			if (this.TravellerRef != null)
			{
				result.TravellerRef = new RefList<int>(this.TravellerRef);
			}

			if (this.Taxes != null)
			{
				result.Taxes = new TaxList();

				foreach (var tax in this.Taxes)
				{
					result.Taxes.Add(tax.Copy());
				}
			}

			if (this.Tariffs != null)
			{
				result.Tariffs = new TariffList();

				foreach (var tariff in this.Tariffs)
				{
					var airTariff = tariff as AirTariff;
					if (airTariff != null)
					{
						result.Tariffs.Add(airTariff.Copy());
					}
				}
			}

			return result;
		}

		private Money equiveFare;
	}
}