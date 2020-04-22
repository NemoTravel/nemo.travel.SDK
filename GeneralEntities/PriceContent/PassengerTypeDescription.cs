using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class PassengerTypeDescription
	{
		/// <summary>
		/// Код типа пассажира, который надо указывать в запросах к ГДС что бы получить нужный тариф
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public string Code { get; set; }

		/// <summary>
		/// Тип пассажира, которому эквивалентент данный, значения из энума авиа сервера
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PassTypes? GeneralType { get; set; }

		/// <summary>
		/// Минимальный возраст пассажира по данному типу, учитывается при проверке, т.е. это число и выше, пример - 0
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? MinAge { get; set; }

		/// <summary>
		/// Максимальный возраст пассажира по данному типу, не учитывается при проверке, т.е. проверку пройдёт только то, что меньше этого числа, пример - 2
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public int? MaxAge { get; set; }

		/// <summary>
		/// Минимальный возраст пассажира по данному типу для пассажиров мужского пола, учитывается при проверке, т.е. это число и выше, пример - 60
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public int? MinMaleAge { get; set; }

		/// <summary>
		/// Минимальный возраст пассажира по данному типу для пассажиров женского пола, учитывается при проверке, т.е. это число и выше, пример - 55
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public int? MinFemaleAge { get; set; }

		/// <summary>
		/// Признак что пассажир должен сопровождаться другим пассажиром (ADT)
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = true)]
		public bool NeedAccompaniment { get; set; }

		/// <summary>
		/// Признак, что данный тип описывает пассажира-инвалида
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = true)]
		public bool IsDisabled { get; set; }

		/// <summary>
		/// Признак, что данный тип описывает пассажира, сопровождающего инвалида
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = true)]
		public bool AccompaniesTheDisabled { get; set; }

		/// <summary>
		/// Обязательность отчества
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = true)]
		public bool NeedMiddleName { get; set; }

		/// <summary>
		/// Набор допустимых документов для бронирования
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public DocumentList ValidDocuments { get; set; }

		/// <summary>
		/// Набор спецдокументов для бронирования
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public DocumentList ValidSpecialsDocuments { get; set; }

		/// <summary>
		/// Описание для клиента
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public MultiLanguageDictionary DescriptionForCustomer { get; set; }

		/// <summary>
		/// Описание для агента
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public MultiLanguageDictionary DescriptionForAgent { get; set; }

		/// <summary>
		/// Понятное название пассажира
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public MultiLanguageDictionary Header { get; set; }
	}
}