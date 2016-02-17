using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalServicesSearch
{
	/// <summary>
	/// Результат поиска допуслуг для определённого перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalServicesSearchRSBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Найденные допуслуги для указанного перелёта
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public AdditionalServiceSegmentList AdditionalServicesForSegments { get; set; }
	}
}