using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание данных для скидки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class DiscountDataItem : CommissionDataItem
	{
		/// <summary>
		/// Код авторизации скидки
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public string AuthCode { get; set; }
	}
}