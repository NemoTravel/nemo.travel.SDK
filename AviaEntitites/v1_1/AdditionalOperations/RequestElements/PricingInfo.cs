using GeneralEntities.Shared;
using System.Linq;
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
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		/// <summary>
		/// При репрайсинге использовать только конкретные коды типов пассажиров, по возможности
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public bool PriceSpecifiedPassTypesOnly { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public int? RefererID { get; set; }

		/// <summary>
		/// Не включать ВП в запрос
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public bool DoNotSendVCInRequest { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public string ThreeDomainAgreementNumber { get; set; }

		/// <summary>
		/// Принудительное выключение микширования
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public bool IsMixerDisabled { get; set; }


		public void CopyTo(PricingInfo newObject)
		{
			base.CopyTo(newObject);

			newObject.IgnoreRepricingSettings = IgnoreRepricingSettings;
			newObject.PriceSpecifiedPassTypesOnly = PriceSpecifiedPassTypesOnly;
			newObject.DoNotSendVCInRequest = DoNotSendVCInRequest;
			newObject.RefererID = RefererID;
			newObject.ThreeDomainAgreementNumber = ThreeDomainAgreementNumber;
			newObject.IsMixerDisabled = IsMixerDisabled;

			if (RequestorTags != null)
			{
				newObject.RequestorTags = new TagList(RequestorTags.ToList());
			}
		}
	}
}