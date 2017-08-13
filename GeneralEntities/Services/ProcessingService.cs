using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Содержит описание услуги по обработке
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ProcessingService : ItemIdentification<int>
	{
		/// <summary>
		/// Тип обработки
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public ProcessingServiceType Type { get; set; }

		/// <summary>
		/// Статус данной услуги
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public ProcessingServiceStatus Status { get; set; }

		/// <summary>
		/// Признак что данная услуга была получена от поставщика контента, а не сформирована в Немо
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool FromSupplier { get; set; }

		/// <summary>
		/// Признак что цена данной услуги уже включена в цену базовой услуги
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool IncludedInMainServicePrice { get; set; }

		/// <summary>
		/// ИД правила, по которому была сформирована цена данной услуги
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string RuleID { get; set; }

		/// <summary>
		/// Дополнительная информация по услуге в свободной форме
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string AdditionalInfo { get; set; }

		/// <summary>
		/// RFIC данной услуги
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string RFIC { get; set; }

		/// <summary>
		/// RFISC данной услуги
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string RFISC { get; set; }
	}
}