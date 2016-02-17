using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Информация о сегменте от поставщика
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SupplierSegmentInfo
	{
		/// <summary>
		/// Статус сегмента в системе поставщика
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Status { get; set; }

		/// <summary>
		/// Код брони для данного сегмента в системе а/к
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string SupplierRef { get; set; }
	}
}