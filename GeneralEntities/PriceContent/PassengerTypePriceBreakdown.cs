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
					else
					{
						return null;
					}
				}
				else
				{
					return equiveFare;
				}
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
		/// Получение тарифа для определённого сегмента услуги, в случае если подобная привязка допустима
		/// </summary>
		/// <param name="segmentID">ИД сегмента в услуге, для которого требуется получить тариф</param>
		/// <returns>Тариф для указанной услуги</returns>
		public BaseTariff GetTariffForSegment(int segmentID)
		{
			return Tariffs != null ? Tariffs.Find(t => t is AirTariff && ((AirTariff)t).SegmentID == segmentID) : null;
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

		public IEnumerable<AirTariff> GetAirTariffs()
		{
			if (Tariffs == null)
			{
				return Enumerable.Empty<AirTariff>();
			}

			return Tariffs.OfType<AirTariff>();
		}

		private Money equiveFare;
	}
}