using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание НДС
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class VATData
	{
		/// <summary>
		/// Значение НДС
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public Money VATValue { get; set; }

		/// <summary>
		/// Ставка НДС
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public double VATRate { get; set; }
	}
}