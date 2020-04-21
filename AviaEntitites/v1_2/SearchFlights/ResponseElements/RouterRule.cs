using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	/// <summary>
	/// Правило маршрутизации
	/// </summary>
	[DataContract(Namespace = "http://nemo.travel/Avia")]
	public class RouterRule
	{
		public RouterRule(int ruleID, IEnumerable<int> sources = null)
		{
			RuleID = ruleID;

			if (sources != null)
			{
				TargetPackages = new PackageList(sources);
			}
		}

		/// <summary>
		/// ID правила
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int RuleID { get; set; }

		/// <summary>
		/// Список пакетов, по которым идет поиск по данному правилу
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PackageList TargetPackages { get; set; }
	}
}