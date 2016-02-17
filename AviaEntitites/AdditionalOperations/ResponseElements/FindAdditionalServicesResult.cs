using AviaEntities.AdditionalServicesSearch;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат поиска допуслуг для перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FindAdditionalServicesResult
	{
		/// <summary>
		/// Найденные допуслуги для указанного объекта
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public AdditionalServiceSegmentList AdditionalServices { get; set; }
	}
}