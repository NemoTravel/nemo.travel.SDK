using GeneralEntities;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using GeneralEntities.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит всю информацию о цене перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class Price : ItemIdentification<long>
	{
		protected DateTimeEx ticketTimeLimit;

		/// <summary>
		/// Не сериализуемое в ХМЛ поле, [код ТП] = строка - секция RulesInfo, которая нужна для получения текста ТП в будущем
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public Dictionary<string, string> RulesInfos { get; set; }

		/// <summary>
		/// Индикатор возвратности
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public RefundableEnum Refundable { get; set; }

		/// <summary>
		/// Признак того, что в цене участвуют некие приватные тарифы
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public bool PrivateFareInd { get; set; }

		/// <summary>
		/// Тайм лимит
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
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
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public List<PassengerFare> PassengerFares { get; set; }

		/// <summary>
		/// Вычисление полной цены перелёта по всем пассажирам
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public Money TotalPrice
		{
			get
			{
				if (PassengerFares != null && PassengerFares.Count > 0)
				{
					var result = PassengerFares[0].TotalFare * PassengerFares[0].Quantity;
					for (int i = 1; i < PassengerFares.Count; i++)
					{
						result += (PassengerFares[i].TotalFare * PassengerFares[i].Quantity);
					}

					return result;
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Получение числа пассажиров, которым необходимы места
		/// </summary>
		public int TotalPassengerNumberWithSeats
		{
			get
			{
				int cnt = 0;

				foreach (var passFare in PassengerFares)
				{
					if (passFare.Type != PassTypes.INF)
					{
						cnt += passFare.Quantity;
					}
				}
				return cnt;
			}
		}

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public Price()
		{
			PassengerFares = new List<PassengerFare>();
		}

		/// <summary>
		/// Выполняет полное копирование объекта, реализация интерфейса ICloneable
		/// </summary>
		/// <returns>Результат копирования</returns>
		public Price Copy()
		{
			Price result = new Price();

			result.Refundable = Refundable;
			result.ID = ID;
			result.PrivateFareInd = PrivateFareInd;
			result.TicketTimeLimit = TicketTimeLimit;

			if (RulesInfos != null && RulesInfos.Count > 0)
			{
				result.RulesInfos = new Dictionary<string, string>();

				foreach (var kvp in RulesInfos)
				{
					result.RulesInfos.Add(kvp.Key, kvp.Value);
				}
			}

			foreach (var pass in PassengerFares)
			{
				result.PassengerFares.Add(pass.Copy());
			}

			return result;
		}

		/// <summary>
		/// Простановка ТЛ услуги
		/// </summary>
		/// <param name="timeLimit">Новый ТЛ услуги</param>
		public void SetTimeLimit(string timeLimit)
		{
			ticketTimeLimit = new DateTimeEx(timeLimit, Formats.FULL_DATE_TIME_FORMAT);
		}
	}
}