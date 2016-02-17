using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.RequestElements
{
	/// <summary>
	/// Содержит требования к перелёту
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ScheduleFlightDirection")]
	public class ScheduleFlightDirection
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
				else
				{
					return FlightDirectionType.OW;
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
		/// Собственно запрашиваемый сегмент перелёта
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public ScheduleFlightPair ODPair { get; set; }
	}
}