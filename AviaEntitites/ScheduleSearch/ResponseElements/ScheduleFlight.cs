using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.ResponseElements
{
	/// <summary>
	/// Содержит перелёт - один из результатов поиск
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ScheduleFlight : AviaEntities.v1_1.FlightSearch.ResponseElements.Flight
	{
		/// <summary>
		/// Сегменты перелёта
		/// </summary>
		[DataMember(Name = "ScheduleSegments", EmitDefaultValue = false)]
		public new ScheduleCompleteSegmentList Segments { get; set; }
	}
}