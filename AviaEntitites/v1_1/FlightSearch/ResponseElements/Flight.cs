using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит перелёт - один из результатов поиск
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Flight_1_1")]
	public class Flight : ItemIdentification<string>
	{
		/// <summary>
		/// ИД пакета реквизитов, из которого был получен данный перелёт
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public int SourceID { get; set; }

		/// <summary>
		/// Информация о типизации данного перелёта по различным критериям
		/// </summary>
		[DataMember(Order = 2)]
		public FlightTypeInfo TypeInfo { get; set; }

		/// <summary>
		/// Признак, что на перелёте возможно есть допуслуги
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool AdditionalServicePossiblyExist { get; set; }

		/// <summary>
		/// Сегменты перелёта
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public CompleteSegmentList Segments { get; set; }

		/// <summary>
		/// Цены перелёта
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public PriceList PriceInfo { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }

		/// <summary>
		/// Вычисление полной цены перелёта по всем пассажирам
		/// </summary>
		[IgnoreDataMember]
		public Money TotalPrice
		{
			get
			{
				if (PriceInfo != null && PriceInfo.Count(pi => pi.PassengerFares != null && pi.PassengerFares.Count > 0) > 0)
				{
					Money result = null;
					foreach (var price in PriceInfo)
					{
						if (price.PassengerFares != null && price.PassengerFares.Count > 0)
						{
							result = price.PassengerFares[0].TotalFare * price.PassengerFares[0].Quantity;
							for (int i = 1; i < price.PassengerFares.Count; i++)
							{
								result += (price.PassengerFares[i].TotalFare * price.PassengerFares[i].Quantity);
							}

							
						}
					}
					return result;
				}
				else
				{
					return null;
				}
			}
		}
	}
}