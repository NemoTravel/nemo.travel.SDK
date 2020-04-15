using AviaEntities.ImportBook.RequestElements;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.ImportBook
{
	/// <summary>
	/// Тело запроса на создание брони на основании ПНРа из ГДС
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ImportBookRQBody
	{
		/// <summary>
		/// ИД источника, в котором находится данный ПНР
		/// </summary>
		[DataMember(Order = 0)]
		public int? Source { get; set; }

		/// <summary>
		/// Код ПНРа, на основании которого будет создаваться бронь
		/// </summary>
		[DataMember(Order = 1, IsRequired = false)]
		public string PNRCode { get; set; }

		/// <summary>
		/// Номер билета, на основании которого будет создаваться бронь. Используетися только для сирены
		/// </summary>
		[DataMember(Order = 2, IsRequired = false)]
		public string TicketNumber { get; set; }

		/// <summary>
		/// Фамилия контактного пассажира, необходима в Сирене при чтении ПНРа
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string MainPassengerLastName { get; set; }

		/// <summary>
		/// Признак необходимости обновить цену брони после создания (не актуально для Сирены)
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool WithReprice { get; set; }

		/// <summary>
		/// ВП импортируемой брони, необходим для корректного импорта в случае мультиРСС пакета
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Признак использования флекс семейств (специфика Габрика)
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public bool UseFlexFares { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public int? RefererID { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false, IsRequired = false)]
		public SourceDescription SourceDescription { get; set; }
	}
}