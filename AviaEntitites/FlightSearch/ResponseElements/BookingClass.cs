using GeneralEntities;
using GeneralEntities.Shared;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Информация о классе бронирования
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class BookingClass
	{
		/// <summary>
		/// Базовый класс перелёта
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public BaseClass? BaseClass { get; set; }

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
		/// Допустимая мера багажа для данного класса перелёта
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Baggage Baggage { get; set; }


		/// <summary>
		/// Конструктор без параметров необходим сериализатору
		/// </summary>
		public BookingClass() { }

		/// <summary>
		/// Создание объекта класс с инициализацией полей
		/// </summary>
		/// <param name="bookingClassCode">Класс перелёта</param>
		/// <param name="baseClass">Базовый класс перелёта</param>
		/// <param name="baggage">Допустимая мера багажа для данного класса перелёта</param>
		public BookingClass(string bookingClassCode, BaseClass? baseClass = null, int freeSeatCount = -1, string mealType = null, Baggage baggage = null)
		{
			BookingClassCode = bookingClassCode;
			BaseClass = baseClass;
			Baggage = baggage;
			MealType = mealType;

			FreeSeatCount = freeSeatCount >= 0 ? freeSeatCount : (int?)null;
		}
	}
}