using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Client
{
	/// <summary>
	/// Контактный телефон
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class Telephone
	{
		/// <summary>
		/// Тип телефона
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public TelephoneTypes Type { get; set; }

		/// <summary>
		/// Номер телефона
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string PhoneNumber { get; set; }


		public Telephone() { }

		public Telephone(string number, TelephoneTypes type)
		{
			Type = type;
			PhoneNumber = number;
		}
	}
}