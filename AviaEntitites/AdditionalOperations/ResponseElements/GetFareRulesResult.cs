using AviaEntities.RulesSearch;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат операции получения тарифных правил
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetFareRulesResult
	{
		/// <summary>
		/// Массив тарифных правил
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public FareRuleList Rules { get; set; }
	}
}