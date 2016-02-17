using AviaEntities.BookFlight.RequestElements;
using AviaEntities.SharedElements;
using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.BookFlight
{
	/// <summary>
	/// Тело запроса на создание брони перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookFlightRQBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Валидирующий перевозчик
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Код валюты, в которой будет создаваться бронь
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Пользовательский тайм-лимит брони в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx TicketTimeLimit { get; set; }

		/// <summary>
		/// Номер брони в очереди
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string QueueNum { get; set; }

		/// <summary>
		/// Информация об агентстве, выполняющем бронирование перелёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public AgencyInfo Agency { get; set; }

		/// <summary>
		/// Пассажиры, для которых бронируется перелёт
		/// </summary>
		[DataMember(IsRequired = true, Order = 6)]
		public List<Traveller> Travellers { get; set; }
	}
}