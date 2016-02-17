using GeneralEntities;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию о типе перелёта
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightTypeInfo
	{
		/// <summary>
		/// Тип перелёта
		/// </summary>
		[DataMember(Order = 0)]
		public FlightType Type { get; set; }

		/// <summary>
		/// Тип маршрута перелёта
		/// </summary>
		[DataMember(Order = 1)]
		public FlightDirectionType DirectionType { get; set; }

		/// <summary>
		/// Подтип перелёта, по факту пока что просто признак мультиOW плеча
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool MultyOWLeg { get; set; }
	}
}