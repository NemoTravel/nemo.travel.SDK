using GeneralEntities;
using GeneralEntities.Market;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит цену перелёта из рассчёта на 1 пассажира конкретного типа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "PassengerFare_1_1")]
	public class PassengerFare
	{
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
		public TariffList Tariffs { get; set; }

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
	}
}