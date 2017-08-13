using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations.RequestElements
{
	/// <summary>
	/// Содержит описание параметров прайсинга перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "PricingInfo_1_1")]
	public class PricingInfo : AviaEntities.AdditionalOperations.RequestElements.PricingInfo
	{
		/// <summary>
		/// Включает игнорирование настроек репрайсинга перелёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool IgnoreRepricingSettings { get; set; }

		/// <summary>
		/// Информация об ициниализаторе поиска в системе, приславшей запрос
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		/// <summary>
		/// При репрайсинге использовать только конкретные коды типов пассажиров, по возможности
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public bool PriceSpecifiedPassTypesOnly { get; set; }
	}
}