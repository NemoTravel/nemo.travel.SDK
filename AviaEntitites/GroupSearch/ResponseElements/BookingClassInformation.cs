using AviaEntities.FlightSearch.ResponseElements;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Информация о классе перелёта для определённого сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookingClassInformation : BookingClass
	{
		/// <summary>
		/// Номер сегмента в перелёте
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public long SegmentNumber { get; set; }

		/// <summary>
		/// Индикатор конект сегмента
		/// </summary>
		[IgnoreDataMember]
		[JsonProperty]
		public bool Connection { get; set; }

		/// <summary>
		/// Дефолтный конструктор без инициализации параметров, нужен сериализаторам
		/// </summary>
		public BookingClassInformation()
		{ }

		/// <summary>
		/// Конструтор с инициализацией свойств объекта
		/// </summary>
		/// <param name="segment">Исходные данные для заполнения объекта</param>
		public BookingClassInformation(CompleteSegment segment)
		{
			Baggage = segment.BookingClassInfo.Baggage;
			BaseClass = segment.BookingClassInfo.BaseClass;
			BookingClassCode = segment.BookingClassInfo.BookingClassCode;
			FreeSeatCount = segment.BookingClassInfo.FreeSeatCount;
			MealType = segment.BookingClassInfo.MealType;

			SegmentNumber = segment.ID;
			Connection = segment.Connection;
		}
	}
}