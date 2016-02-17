using AviaEntities.ScheduleSearch.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch
{
	/// <summary>
	/// Содержит результат поиска по расписанию
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ScheduleSearchRSBody
	{
		/// <summary>
		/// Перелёты
		/// </summary>
		[DataMember(IsRequired = true, Order = 0, EmitDefaultValue = false)]
		public ScheduleFlightList Flights { get; set; }
	}
}
