using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	/// <summary>
	/// Содержит требования к перелёту
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightDirection_1_2")]
	public class FlightDirection
	{
		protected FlightDirectionType? preSettedType;

		/// <summary>
		/// Тип перелёта (в одну сторону, туда-обратно, сложный маршрут)
		/// </summary>
		[IgnoreDataMember]
		public FlightDirectionType Type
		{
			get
			{
				//если есть проставленный тип (в основном это имеется ввиду RT/2 и OW+OW+)
				if (preSettedType.HasValue)
				{
					return preSettedType.Value;
				}
				else//если нету, то определяем по морфологии сегментов запроса
				{
					if (ODPairs.Count == 1)
					{
						return FlightDirectionType.OW;
					}
					else if (ODPairs.Count == 2)
					{
						if (ODPairs[0].DepaturePoint.Code == ODPairs[1].ArrivalPoint.Code && ODPairs[0].ArrivalPoint.Code == ODPairs[1].DepaturePoint.Code)
						{
							return FlightDirectionType.RT;
						}
						else if (ODPairs[0].DepaturePoint.Code == ODPairs[1].ArrivalPoint.Code || ODPairs[0].ArrivalPoint.Code == ODPairs[1].DepaturePoint.Code)
						{
							return FlightDirectionType.SingleOJ;
						}
						else
						{
							return FlightDirectionType.DoubleOJ;
						}
					}
					else
					{
						return FlightDirectionType.CT;
					}
				}
			}
			set
			{
				preSettedType = value;
			}
		}

		/// <summary>
		/// Подтип данного поиского запроса
		/// </summary>
		[IgnoreDataMember]
		public FlightDirectionType? SubType { get; set; }

		/// <summary>
		/// Прямые перелёты или с пересадками
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public bool Direct { get; set; }

		/// <summary>
		/// Значение диапазона для поиска по окружным датам
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public uint AroundDates { get; set; }

		/// <summary>
		/// Собственно запрашиваемые сегменты перелёта
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public FlightPairList ODPairs { get; set; }
	}
}