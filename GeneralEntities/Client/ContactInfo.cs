using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Client
{
	/// <summary>
	/// Содержит контактную информацию пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class ContactInfo
	{
		/// <summary>
		/// Адрес элетронной почты пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 0, EmitDefaultValue = false)]
		public string EmailID { get; set; }

		/// <summary>
		/// Контактный телефон пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 1, EmitDefaultValue = false)]
		public Telephone Telephone { get; set; }
	}
}