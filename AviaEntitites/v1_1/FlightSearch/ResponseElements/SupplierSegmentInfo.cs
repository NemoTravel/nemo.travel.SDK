using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Информация о сегменте от поставщика
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "SupplierSegmentInfo_1_1")]
	public class SupplierSegmentInfo
	{
		/// <summary>
		/// Статус сегмента в системе поставщика
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Status { get; set; }

		/// <summary>
		/// Обобщённый статус сегмента
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PNRContentStatus? GeneralizedStatus { get; set; }

		/// <summary>
		/// Код брони для данного сегмента в системе а/к
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string SupplierRef { get; set; }
	}
}