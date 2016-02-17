using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат получения списка а/к, чьи карточки лояльности принимаются на перелёте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetAllowedLoyaltyCardsResult
	{
		/// <summary>
		/// Список а/к, чьи карточки можно добавлять для всего перелёта целиком
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public AirlineList AirlineLoyaltyCardsForEntireFlight { get; set; }

		/// <summary>
		/// Список а/к, чьи карточки можно добавлять для каждого из сегментов в отдельности
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public AirlinesForSegments AirlineLoyaltyCardsForSegments { get; set; }
	}
}