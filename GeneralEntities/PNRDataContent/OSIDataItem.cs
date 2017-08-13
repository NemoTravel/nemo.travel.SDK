using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// OSI - Other service information (Прочая служебная информация)
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class OSIDataItem
	{
		/// <summary>
		/// Текст с информацией
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Text { get; set; }
	}
}
