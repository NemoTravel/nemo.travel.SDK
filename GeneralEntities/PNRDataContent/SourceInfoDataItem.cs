using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Информация об источнике, где была создана бронь
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class SourceInfoDataItem
	{
		/// <summary>
		/// ИД источника в системе
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int ID { get; set; }

		/// <summary>
		/// ИД агента в системе поставщика, под которым бронь создана
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string BookingSupplierAgencyID { get; set; }

		/// <summary>
		/// ИД агента в системе поставщика, под которым бронь (будет) выписана
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string TicketingSupplierAgencyID { get; set; }

		/// <summary>
		/// Поставщик услуги, где была создана бронь
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public AviaSuppliers Supplier { get; set; }

		/// <summary>
		/// Среда в системе поставщика
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public EnvironmentType Environment { get; set; }

		/// <summary>
		/// IATA валидатор выписки билетов
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string TicketingIATAValidator { get; set; }
	}
}