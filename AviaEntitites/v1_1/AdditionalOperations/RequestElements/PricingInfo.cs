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
	}
}