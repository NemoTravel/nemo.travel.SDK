using GeneralEntities.Market.Markups;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Дополнительная ценовая информация
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalPriceInfo
	{
		/// <summary>
		/// Комиссия
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public Modificants Commission { get; set; }

		/// <summary>
		/// Сбор
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Modificants Markup { get; set; }

		/// <summary>
		/// Маржа
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Modificants Margin { get; set; }
	}
}