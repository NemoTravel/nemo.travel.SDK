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