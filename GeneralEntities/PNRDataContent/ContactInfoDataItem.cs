using GeneralEntities.Client;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание контактной информации клиента
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ContactInfoDataItem
	{
		/// <summary>
		/// Адрес элетронной почты пассажира
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string EmailID { get; set; }

		/// <summary>
		/// Контактный телефон пассажира
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Telephone Telephone { get; set; }
	}
}