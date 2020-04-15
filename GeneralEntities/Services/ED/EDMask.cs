using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using GeneralEntities.PNRDataContent;
using GeneralEntities.PNRDataContent.Ancillary;
using GeneralEntities.PriceContent;
using GeneralEntities.Traveller;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.ED
{
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class EDMask
	{
		/// <summary>
		/// Номер ЭД
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Номер билета, который был обменен
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string ExchangedTicketNumber { get; set; }

		/// <summary>
		/// Номер дополнительного/присоединённого документа.
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public ConjunctionTicketNumberList ConjunctionNumbers { get; set; }

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
		/// Информация о пассажире
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public TravellerInformation Traveller { get; set; }

		/// <summary>
		/// BaseService или ProcessingService
		/// </summary>
		[DataMember(Order = 6)]
		public Services Service { get; private set; }

		/// <summary>
		/// Цена услуги
		/// </summary>
		[DataMember(Order = 7)]
		public Price Price { get; set; }

		/// <summary>
		/// DataItems
		/// </summary>
		[DataMember(Order = 8)]
		public List<BasePNRDataItem> DataItems { get; set; }

		/// <summary>
		/// НДС на услугу, предоставляемую по данному ЭД
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Money VAT { get; set; }

		/// <summary>
		/// Информация о НДС
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public VATBreakdown VATBreakdown { get; set; }

		/// <summary>
		/// Реквизит выписки
		/// </summary>
		[DataMember(Order = 11)]
		public string IssuierSupplierID { get; set; }
		
		/// <summary>
		/// IATA код агента
		/// </summary>
		[DataMember(Order = 12)]
		public string AgencyIATACode { get; set; }

		public EDMask()
		{
			Service = new Services();
		}
	}
}
