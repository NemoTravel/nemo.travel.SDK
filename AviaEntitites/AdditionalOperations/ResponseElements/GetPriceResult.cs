using AviaEntities.v1_1.FlightSearch.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат получения актуальной цены перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetPriceResult
	{
		/// <summary>
		/// Перелёт с актуальной ценой
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public Flight Flight { get; set; }
	}
}