using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание для сбора агентства
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class MarkupDataItem
	{
		/// <summary>
		/// Значение сбора
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public Money MarkupValue { get; set; }

		/// <summary>
		/// Информация по НДС сбора
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public VATData VAT { get; set; }

		public MarkupDataItem Copy()
		{
			var result = new MarkupDataItem();

			result.MarkupValue = MarkupValue?.Copy();
			result.VAT = VAT?.Copy();

			return result;
		}
	}
}