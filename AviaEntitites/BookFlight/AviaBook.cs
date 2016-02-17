using AviaEntities.BookFlight.RequestElements;
using AviaEntities.BookFlight.ResponseElements;
using AviaEntities.FlightSearch.ResponseElements;
using GeneralEntities;
using GeneralEntities.Shared;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight
{
	/// <summary>
	/// Тело ответа на запрос создания брони, содержит всю информацию о брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class AviaBook : ItemIdentification<long>
	{
		/// <summary>
		/// Статус брони
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public BookStatus Status { get; set; }

		/// <summary>
		/// Код брони в конкретной ГДС
		/// </summary>
		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		/// Тип оплаты из ПНРа
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public PaymentType? StoredPaymentType { get; set; }

		/// <summary>
		/// Положение брони в очереди
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public int? QueryPlace { get; set; }

		/// <summary>
		/// Перелёт, по которому создана бронь
		/// </summary>
		[DataMember(IsRequired = true, Order = 5, EmitDefaultValue = false)]
		public Flight Flight { get; set; }

		/// <summary>
		/// Пассажиры
		/// </summary>
		[DataMember(IsRequired = true, Order = 6, EmitDefaultValue = false)]
		public BookedTravellerList Travellers { get; set; }

		/// <summary>
		/// Информация об агенстве
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public AgencyInfo Agency { get; set; }

		/// <summary>
		/// Список маршрутных квитанций
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public ItinReceiptsList Receipts { get; set; }

		/// <summary>
		/// Индикатор успешности установки цены в Галилео
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public bool FareStored { get; set; }

		/// <summary>
		/// Допслуги, купленные в рамках данной брони
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public List<BookedAdditionalService> BookedAdditionalServices { get; set; }

		/// <summary>
		/// реквизиты только в латинице
		/// </summary>
		[IgnoreDataMember]
		public bool LatinRegistration { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public AviaBook()
		{
			Travellers = new BookedTravellerList();
			LatinRegistration = true;
			FareStored = true;
		}
	}
}