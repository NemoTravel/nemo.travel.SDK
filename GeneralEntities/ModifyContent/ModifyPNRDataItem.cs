using GeneralEntities.PNRDataContent;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	/// <summary>
	/// Содержит описание данных для модификации контента брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ModifyPNRDataItem : BaseModifyItem
	{
		/// <summary>
		/// Изменяемый элемент
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public PNRDataItem DataItem { get; set; }
	}
}