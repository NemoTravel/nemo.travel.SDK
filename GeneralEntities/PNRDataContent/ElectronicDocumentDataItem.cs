using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using GeneralEntities.PNRDataContent.Ancillary;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание базовой информации об электронном документе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ElectronicDocumentDataItem
	{
		/// <summary>
		/// Номер ЭД
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Номер дополнительного/присоединённого документа.
		/// Встречается для билетов в Галилео на перелётах с более чем 4 сегмента
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public ConjunctionTicketNumberList ConjunctionNumbers { get; set; }

		/// <summary>
		/// Его статус
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public EDStatus Status { get; set; }

		/// <summary>
		/// Тип услуги, на которую применяется данный ЭД
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public EDServiceType ServiceType { get; set; }

		/// <summary>
		/// Дата и время оформления ЭД, включая часовой пояс
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public DateTimeEx IssueDateTime { get; set; }

		/// <summary>
		/// Признак что данный билет не сохранён в ПНРе
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool NotStoredInPNR { get; set; }

		/// <summary>
		/// ТЛ на выполнение услуги
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public DateTimeEx ExecutionTimeLimit { get; set; }

		/// <summary>
		/// Специфичные для ЕМД данные
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public EMDSpecificData EMDSpecificData { get; set; }

		/// <summary>
		/// НДС на услугу, предоставляемую по данному ЭД
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public Money VAT { get; set; }

		/// <summary>
		/// Информация о НДС
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public VATBreakdown VATBreakdown { get; set; }
	}
}