using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Содержит информацию о таксе цены
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Tax : Money
	{
		/// <summary>
		/// Код таксы
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string TaxCode { get; set; }

		/// <summary>
		/// Тип таксы, специфика Амадеуса
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		/// Природа таксы, специфика Амадеуса
		/// </summary>
		public string Nature { get; set; }
	}
}