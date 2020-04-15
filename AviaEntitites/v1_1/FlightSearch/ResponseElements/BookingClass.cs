using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Информация о классе бронирования
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookingClass
	{
		/// <summary>
		/// Базовый класс перелёта
		/// </summary>
		[DataMember(Order = 0)]
		public BaseClass BaseClass { get; set; }

		/// <summary>
		/// Класс перелёта
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string BookingClassCode { get; set; }

		/// <summary>
		/// Количество свободных мест
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? FreeSeatCount { get; set; }

		/// <summary>
		/// Тип питания в данном классе обслуживания на данном сегменте перелёта
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string MealType { get; set; }

		/// <summary>
		/// Допуслуги, доступные на данном сегменте перелёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public List<AdditionalService> AdditionalServices { get; set; }

		/// <summary>
		/// Количество свободных мест по предыдущей литере
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public int? OldFreeSeatCount { get; set; }
	}
}