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
		/// <summary>
		/// Предустановленный тип перелёта (в одну сторону, туда-обратно, сложный маршрут)
		/// </summary>
		[IgnoreDataMember]
		public FlightDirectionType? ForcedType { get; set;}

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