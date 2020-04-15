using AviaEntities.Lib;
using GeneralEntities;
using GeneralEntities.Market;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит цену перелёта из рассчёта на 1 пассажира конкретного типа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class PassengerFare
	{
		/// <summary>
		/// Сиреновская специфическая информация, необходимая для поиска тарифных правил
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public Dictionary<string, UPT> Upt { get; set; }

		/// <summary>
		/// Тип пассажиров
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public PassTypes Type { get; set; }

		/// <summary>
		/// Число пассажиров данного типа
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public int Quantity { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string PricedAs { get; set; }

		/// <summary>
		/// Цена в базовой валюте
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public Money BaseFare { get; set; }

		/// <summary>
		/// Цена в эквивалентной валюте
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Money EquiveFare { get; set; }

		/// <summary>
		/// Суммарная цена для 1 пассажира данного типа
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public Money TotalFare { get; set; }

		/// <summary>
		/// Таксы
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public List<Tax> Taxes { get; set; }

		/// <summary>
		/// Тарифы
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public List<Tariff> Tariffs { get; set; }

		/// <summary>
		/// Комиссия
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public ServiceCommission Commission { get; set; }

		/// <summary>
		/// Строка рассчёта цены
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public string FareCalc { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public PassengerFare()
		{ }

		/// <summary>
		/// Полное копирование объекта
		/// </summary>
		/// <returns>Копия объекта</returns>
		public PassengerFare Copy()
		{
			var result = new PassengerFare();

			result.FareCalc = FareCalc;
			result.Quantity = Quantity;
			result.Type = Type;
			result.PricedAs = PricedAs;
			result.Upt = Upt;

			if (BaseFare != null)
			{
				result.BaseFare = new Money(BaseFare);
			}

			if (EquiveFare != null)
			{
				result.EquiveFare = new Money(EquiveFare);
			}
			else
			{
				result.EquiveFare = null;
			}

			if (TotalFare != null)
			{
				result.TotalFare = new Money(TotalFare);
			}

			if (Tariffs != null)
			{
				result.Tariffs = new List<Tariff>();
				foreach (var oldTarif in Tariffs)
				{
					result.Tariffs.Add(oldTarif.Copy());
				}
			}

			if (Taxes != null)
			{
				result.Taxes = new List<Tax>();
				foreach (var oldTax in Taxes)
				{
					var newTax = new Tax();
					newTax.Value = oldTax.Value;
					newTax.Currency = oldTax.Currency;
					newTax.TaxCode = oldTax.TaxCode;
					result.Taxes.Add(newTax);
				}
			}

			return result;
		}
	}
}