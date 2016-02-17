using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.RulesSearch
{
	/// <summary>
	/// Тело ответа поиска тарифных правил
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RulesSearchRSBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Массив тарифных правил
		/// </summary>
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public FareRuleList Rules { get; set; }
	}
}