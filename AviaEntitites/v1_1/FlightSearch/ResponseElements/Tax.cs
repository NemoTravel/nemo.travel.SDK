using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию о таксе цены
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Tax : Money
	{
		/// <summary>
		/// Код таксы
		/// </summary>
		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public string TaxCode { get; set; }
	}
}