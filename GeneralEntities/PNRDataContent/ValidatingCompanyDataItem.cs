using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание переопределённого ВП
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ValidatingCompanyDataItem
	{
		/// <summary>
		/// Код ВП
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Признак переопределённого ВП
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool IsForced { get; set; }
	}
}