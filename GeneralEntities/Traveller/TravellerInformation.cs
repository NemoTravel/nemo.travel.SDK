using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Shared;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace GeneralEntities.Traveller
{
	/// <summary>
	/// Содержит описание информации о пассажире/путешественнике
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TravellerInformation : ItemIdentification<int>
	{
		protected DateTimeEx dob;

		/// <summary>
		/// ИД пассажира в ПНРе поставщика
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public int IDInPNR { get; set; }

		/// <summary>
		/// Тип пассажира
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public PassTypes Type { get; set; }

		/// <summary>
		/// Префикс имени (титул, официальное обращение и т.д.)
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string NamePrefix { get; set; }

		/// <summary>
		/// Имя пассажира
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Фамилия
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public string LastName { get; set; }

		/// <summary>
		/// Отчетсво
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string MiddleName { get; set; }

		/// <summary>
		/// Дата рождения
		/// </summary>
		[DataMember(Order = 6, IsRequired = true)]
		public DateTimeEx DateOfBirth
		{
			get { return dob; }
			set
			{
				dob = value;
				if (dob != null)
				{
					dob.OutFormat = Formats.DATE_FORMAT;
				}
			}
		}

		/// <summary>
		/// Гражданство
		/// </summary>
		[DataMember(Order = 7, IsRequired = true)]
		public string Nationality { get; set; }

		/// <summary>
		/// Пол пассажира
		/// </summary>
		[DataMember(Order = 8, IsRequired = true)]
		public GenderTypes Gender { get; set; }

		/// <summary>
		/// Ссылка на пассажира, к которому привязан данный
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public int? LinkedTo { get; set; }

		/// <summary>
		/// Признак инвалида
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public bool IsDisabled { get; set; }


		#region ФИО с транслитерацией

		/// <summary>
		/// Имя пассажира с транслитерацией
		/// </summary>
		[IgnoreDataMember]
		public string NameTL
		{
			get
			{
				return Transliteration.UARUStoENG(Name).ToUpper().Trim();
			}
		}

		/// <summary>
		/// Фамилия пассажира с транслитерацией
		/// </summary>
		[IgnoreDataMember]
		public string LastNameTL
		{
			get { return Transliteration.UARUStoENG(LastName).ToUpper().Trim(); }
		}

		/// <summary>
		/// Отчество пассажира с транслитерацией
		/// </summary>
		[IgnoreDataMember]
		public string MiddleNameTL
		{
			get
			{
				if (MiddleName != null)
				{
					return Transliteration.UARUStoENG(MiddleName).ToUpper().Trim();
				}
				else
				{
					return MiddleName;
				}
			}
		}

		#endregion

		/// <summary>
		/// Получение полного имени для данной сущности
		/// </summary>
		/// <param name="separator">Разделитель в ФИО</param>
		/// <param name="transliterated">Включение транслитерации ФИО</param>
		/// <param name="namePartsToMiddleName"></param>
		/// <returns>ФИО данного пассажира</returns>
		public string GetFullName(string separator = " ", bool transliterated = true, bool namePartsToMiddleName = false)
		{
			var name = transliterated ? NameTL : Name;
			var lastName = transliterated ? LastNameTL : LastName;
			var middleName = transliterated ? MiddleNameTL : MiddleName;

			if (namePartsToMiddleName && name.Split(' ').Length > 1)
			{
				var nameParts = name.Split(' ');
				name = nameParts[0];

				var newMiddleName = new StringBuilder();
				for (int i = 1; i < nameParts.Length; i++)
				{
					newMiddleName.Append(nameParts[i]);
					newMiddleName.Append(' ');
				}
				newMiddleName.Append(middleName);
				middleName = newMiddleName.ToString().Trim();
			}

			return GetFullName(name, lastName, middleName, separator);
		}

		/// <summary>
		/// Получение полного имени без фамилии для данной сущности
		/// </summary>
		/// <param name="separator">Разделитель в ИО</param>
		/// <returns>ИО данного пассажира</returns>
		public string GetFullFirstName(string separator = " ")
		{
			return GetFullName(NameTL, null, MiddleNameTL, separator);
		}

		/// <summary>
		/// Получение отформатированной строки имени пассажира
		/// <para>Опиcание формата:</para>
		/// <para>%FN% Имя</para>
		/// <para>%LN% Фамилия</para>
		/// <para>%MN% Отчество</para>
		/// <para>%PF% Префикс(титул)</para>
		/// </summary>
		/// <param name="format">Формат</param>
		/// <param name="transliterated">Включение транслитерации ФИО</param>
		/// <returns>Отформатированная строка имени пассжаира</returns>
		public string GetFormattedName(string format, bool transliterated = true)
		{
			return format
				.Replace("%FN%", transliterated ? NameTL : Name)
				.Replace("%LN%", transliterated ? LastNameTL : LastName)
				.Replace("%MN%", transliterated ? MiddleNameTL : MiddleName)
				.Replace("%PF%", NamePrefix);
		}

		/// <summary>
		/// Получение возраста пассажира на указанную дату
		/// <para>null если не удалось определить</para>
		/// </summary>
		/// <param name="date">Дата, на момент которой требуется получить возраст пассажира</param>
		/// <returns>Возвраст пассажира, null если не удалось определить</returns>
		public int? GetAge(DateTime date)
		{
			if (DateOfBirth == null)
			{
				return null;
			}

			return date.Year - DateOfBirth.Date.Year - (date.DayOfYear < DateOfBirth.Date.DayOfYear ? 1 : 0);
		}

		public string GetFullNameForDOCS()
		{
			return "/" + LastName + "/" + Name + (MiddleName != null ? "/" + MiddleName[0] : "");
		}


		private string GetFullName(string name, string lastName, string middleName, string separator)
		{
			var result = new StringBuilder();

			if (!string.IsNullOrWhiteSpace(lastName))
			{
				result.Append(lastName.Trim());
				result.Append(separator);
			}

			result.Append(name.Trim());

			if (!string.IsNullOrWhiteSpace(middleName))
			{
				result.Append(separator);
				result.Append(middleName.Trim());
			}

			if (!string.IsNullOrWhiteSpace(NamePrefix))
			{
				result.Append(separator);
				result.Append(NamePrefix.Trim());
			}

			return result.ToString();
		}
	}
}