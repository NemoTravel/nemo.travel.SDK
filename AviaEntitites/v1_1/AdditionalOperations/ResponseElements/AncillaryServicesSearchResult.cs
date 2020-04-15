using AviaEntities.SharedElements.Ancillaries;
using AviaEntities.SharedElements.Ancillaries.ResponseElements;
using AviaEntities.v1_1.AdditionalOperations.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Результат поиска допуслуг для определённого перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServicesSearchResult
	{
		/// <summary>
		/// Найденные допуслуги для указанного перелёта
		/// </summary>
		[DataMember(Order = 0)]
		public AncillaryServices<AncillaryServiceRS> Services { get; set; }

		/// <summary>
		/// Список карточек лояльности для линковки цен
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public LoyaltyCards LoyaltyCards { get; set; }

		/// <summary>
		/// Список цен для найденных допуслуг
		/// </summary>
		[DataMember(Order = 2)]
		public AncillaryServicesPrices Prices { get; set; }


		public AncillaryServicesSearchResult()
		{
			Services = new AncillaryServices<AncillaryServiceRS>();
			Prices = new AncillaryServicesPrices();
		}
	}
}