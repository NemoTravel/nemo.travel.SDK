using AviaEntities.SharedElements;
using AviaEntities.Ticketing.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.Ticketing
{
	/// <summary>
	/// Тело запроса выписки брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TicketingRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Валидирующей перевозчик, под которым будет проводится выписка
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string ValCompany { get; set; }

		/// <summary>
		/// Комиссия для передачи в ГДС
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public FinancialInfo FinancialInformation { get; set; }

		/// <summary>
		/// Эндорсменты
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public EndorsementList Endorsements { get; set; }

		/// <summary>
		/// Тур код для данной брони
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string TourCode { get; set; }

		/// <summary>
		/// Тикет десигнатор для данной брони
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string TicketDesignator { get; set; }

		/// <summary>
		/// Тестово-отладочные параметры
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public TestMode TestMode { get; set; }
	}
}