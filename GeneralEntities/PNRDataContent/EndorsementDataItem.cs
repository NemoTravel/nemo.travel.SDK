using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит эндорсменты брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class EndorsementDataItem
	{
		/// <summary>
		/// Текст эндорсментов
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public TextList EndorsementText { get; set; }
	}
}