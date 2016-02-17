using System;
using System.Runtime.Serialization;
using System.Text;

namespace GeneralEntities.Client
{
	/// <summary>
	/// Общая информация о клиенте
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ClientInfo
	{
		/// <summary>
		/// Персональная информация пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 0, EmitDefaultValue = false)]
		public PersonalInformation PersonalInfo { get; set; }

		/// <summary>
		/// Контактная информация пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 1, EmitDefaultValue = false)]
		public ContactInfo ContactInfo { get; set; }

		/// <summary>
		/// Получение полного имени для данной сущности
		/// </summary>
		/// <param name="separator">Разделитель в ФИО</param>
		/// <param name="transliterated">Включение транслитерации ФИО</param>
		/// <returns>ФИО данного пассажира</returns>
		public string GetFullName(string separator = " ", bool transliterated = true)
		{
			if (PersonalInfo == null)
			{
				return null;
			}

			var result = new StringBuilder();

			if (transliterated)
			{
				result.Append(PersonalInfo.LastNameTL);
				
				result.Append(separator);
				result.Append(PersonalInfo.FirstNameTL);
				
				if (!string.IsNullOrWhiteSpace(PersonalInfo.MiddleName))
				{
					result.Append(separator);
					result.Append(PersonalInfo.MiddleNameTL);
				}
			}
			else
			{
				result.Append(PersonalInfo.LastName.Trim());

				result.Append(separator);
				result.Append(PersonalInfo.FirstName.Trim());

				if (!string.IsNullOrWhiteSpace(PersonalInfo.MiddleName))
				{
					result.Append(separator);
					result.Append(PersonalInfo.MiddleName.Trim());
				}
			}


			return result.ToString();
		}
	}
}