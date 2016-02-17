using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.RulesSearch
{
	/// <summary>
	/// Список тарифных правил
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Rules", ItemName = "Rule")]
	public class FareRuleList : List<FareRule>
	{
	}
}