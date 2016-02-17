using GeneralEntities.Client;
using GeneralEntities.Traveller;
using System.Runtime.Serialization;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Новая контактная информация пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TravellerContactInfo
	{
		/// <summary>
		/// Новый адрес электронной почты
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string NewEmailID { get; set; }

		/// <summary>
		/// Новый контактный телефон
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Telephone NewTelephoneInfo { get; set; }

		/// <summary>
		/// Создаёт новую контактную инфу для модификации, заполняя отсутствующие данные старыми данными
		/// </summary>
		/// <param name="oldInfo">Старая контактная информация</param>
		/// <returns>Созданная контактная информация</returns>
		public ContactInfo CreateContactForModify(ContactInfo oldInfo)
		{
			ContactInfo res = new ContactInfo();

			if (NewEmailID != null)
			{
				res.EmailID = NewEmailID;
			}
			else
			{
				res.EmailID = oldInfo.EmailID;
			}

			if (NewTelephoneInfo != null)
			{
				res.Telephone = new Telephone();
				res.Telephone.PhoneNumber = NewTelephoneInfo.PhoneNumber;
				res.Telephone.Type = NewTelephoneInfo.Type;
			}
			else
			{
				res.Telephone = oldInfo.Telephone;
			}
			return res;
		}
	}
}