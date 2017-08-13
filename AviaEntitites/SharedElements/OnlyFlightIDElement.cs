using System;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements
{
	/// <summary>
	/// Тело для различных запросов, в которых передаётся только ИД перелета, над которым требуется выполнить операции
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class OnlyFlightIDElement
	{
		/// <summary>
		/// ИД перелёта, для которого требуется найти карту мест
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string FlightID { get; set; }
	}
}