using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	/// <summary>
	/// Содержит требования к перелёту
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
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
						if (ODPairs[0].DepAirp == ODPairs[1].ArrAirp && ODPairs[0].ArrAirp == ODPairs[1].DepAirp)
						{
							return FlightDirectionType.RT;
						}
						else if (ODPairs[0].DepAirp == ODPairs[1].ArrAirp || ODPairs[0].ArrAirp == ODPairs[1].DepAirp)
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
		[DataMember(IsRequired = true, Order = 1)]
		public bool Direct { get; set; }

		/// <summary>
		/// Значение диапазона для поиска по окружным датам
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public uint AroundDates { get; set; }

		/// <summary>
		/// Собственно запрашиваемые сегменты перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public FlightPairList ODPairs { get; set; }
	}
}