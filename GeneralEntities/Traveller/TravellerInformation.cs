using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Shared;
using SharedAssembly;
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
		/// <returns>ФИО данного пассажира</returns>
		public string GetFullName(string separator = " ", bool transliterated = true)
		{
			var result = new StringBuilder();

			if (transliterated)
			{
				result.Append(LastNameTL);

				result.Append(separator);
				result.Append(NameTL);

				if (!string.IsNullOrWhiteSpace(MiddleName))
				{
					result.Append(separator);
					result.Append(MiddleNameTL);
				}
			}
			else
			{
				result.Append(LastName.Trim());

				result.Append(separator);
				result.Append(Name.Trim());

				if (!string.IsNullOrWhiteSpace(MiddleName))
				{
					result.Append(separator);
					result.Append(MiddleName.Trim());
				}
			}


			return result.ToString();
		}

		/// <summary>
		/// Получение возраста пассажира на указанную дату
		/// </summary>
		/// <param name="date">Дата, на момент которой требуется получить возраст пассажира</param>
		/// <returns>Возраст пассажира. 0 если дата рождения не указана</returns>
		public int GetAge(DateTime date)
		{
			if (DateOfBirth == null)
			{
				return 0;
			}

			return date.Year - DateOfBirth.Date.Year - (date.DayOfYear < DateOfBirth.Date.DayOfYear ? 1 : 0);
		}
	}
}