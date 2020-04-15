using GeneralEntities.Client;
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

		public override bool Equals(object obj)
		{
			var other = obj as ContactInfoDataItem;
			if (other == null)
			{
				return false;
			}

			return EmailID == other.EmailID && Equals(Telephone, other.Telephone);
		}

		public ContactInfoDataItem Copy()
		{
			var result = new ContactInfoDataItem();

			result.EmailID = EmailID;
			result.Telephone = Telephone?.Copy();

			return result;
		}
	}
}