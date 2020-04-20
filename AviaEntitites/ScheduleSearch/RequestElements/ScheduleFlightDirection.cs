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