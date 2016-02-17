using System;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements
{
	/// <summary>
	/// Тело для различных запросов, в которых передаётся только ИД брони, над которой требуется выполнить операции
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class OnlyBookIDElement
	{
		/// <summary>
		/// ИД брони, над которой требуется выполнить операцию
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public long BookID { get; set; }
	}
}