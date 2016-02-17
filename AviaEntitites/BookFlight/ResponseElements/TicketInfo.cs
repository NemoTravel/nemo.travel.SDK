using GeneralEntities.Market;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Информация о билете в броне
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TicketInfo
	{
		/// <summary>
		/// Номер билета
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string TicketNumber { get; set; }

		/// <summary>
		/// Номера сегментов, к которым относится данный билет.
		/// null если ко всем сегментам перелёта
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public SegmentNumberList SegmentNumbers { get; set; }

		/// <summary>
		/// Значение НДС для данного билета
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Money VAT { get; set; }

		/// <summary>
		/// Пустой конструктор, необходим для сериализатора
		/// </summary>
		public TicketInfo()
		{ }

		/// <summary>
		/// Создание объекта
		/// </summary>
		/// <param name="ticketNum">Номер билета</param>
		public TicketInfo(string ticketNum)
		{
			TicketNumber = ticketNum;
		}
	}
}