using AviaEntities.v1_2.AdditionalOperations.RequestElements;
using GeneralEntities;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations.RequestElements
{
	/// <summary>
	/// Содержит описание параметров для выполнения операций
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalOperationsParameters
	{
		/// <summary>
		/// Проверка доступности через запрос взятия мест
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public bool CheckAvailabilityWithBookingRequest { get; set; }

		/// <summary>
		/// Дополнительная информация для получения актуальной цены перелёта
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PricingInfo PricingInfo { get; set; }

		/// <summary>
		/// Включает получение тарифных правил от ГДС и обновление закэшированных в брони данных
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool UpdateCachedFareRules { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool ListFaresIfNoFamiliesDifined { get; set; }

		/// <summary>
		/// Язык, на котором требуется получить УПТ
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Language? Language { get; set; }

		/// <summary>
		/// Уже выбранные доп. услуги. (Необходимо при поиске доп. услуг в сирене для определения стоимости 2ой и следующих сумок багажа)
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public SelectedAncillaryServicesList SelectedAncillaryServices { get; set; }


		public AdditionalOperationsParameters DeepCopy()
		{
			var result = new AdditionalOperationsParameters();

			result.CheckAvailabilityWithBookingRequest = CheckAvailabilityWithBookingRequest;
			result.UpdateCachedFareRules = UpdateCachedFareRules;
			result.ListFaresIfNoFamiliesDifined = ListFaresIfNoFamiliesDifined;
			result.Language = Language;

			if (PricingInfo != null)
			{
				result.PricingInfo = new PricingInfo();
				PricingInfo.CopyTo(result.PricingInfo);
			}

			if (SelectedAncillaryServices != null)
			{
				result.SelectedAncillaryServices = new SelectedAncillaryServicesList(SelectedAncillaryServices.Select(svc => svc.DeepCopy()));
			}

			return result;
		}
	}
}