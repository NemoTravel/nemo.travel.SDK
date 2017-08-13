using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries
{
	/// <summary>
	/// Содержит информацию об определённой допуслуге
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public abstract class BaseAncillaryService
	{
		/// <summary>
		/// ИД допуслуги в ответе поиска или в запросе модификации
		/// </summary>
		[DataMember(Order = 0)]
		public int ID { get; set; }

		/// Описание допуслуги (ATPCO commercial name)
		/// </summary>
		[DataMember(Order = 1)]
		public string Name { get; set; }

		/// <summary>
		/// Группа допуслуги
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Group { get; set; }

		/// <summary>
		/// Подгруппа допусуги
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string SubGroup { get; set; }

		/// <summary>
		/// RFIC данной допуслуги
		/// </summary>
		[DataMember(Order = 4)]
		public string RFIC { get; set; }

		/// <summary>
		/// RFISC данной допуслуги
		/// </summary>
		[DataMember(Order = 5)]
		public string RFISC { get; set; }

		/// <summary>
		/// Код SSRки, которую необходимо добавить в ПНР в случае покупки данной допуслуги
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string SSRCode { get; set; }

		/// <summary>
		/// Код SSRки, для которой требуется описание от юзера
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string SSRDescription { get; set; }

		/// <summary>
		/// Некий тип допуслуги (специфика Сирены)
		/// </summary>
		[DataMember(Order = 8)]
		public string Type { get; set; }
	}
}