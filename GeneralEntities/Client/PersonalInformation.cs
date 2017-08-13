using Newtonsoft.Json;
using SharedAssembly;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Client
{
	/// <summary>
	/// Персональная информация пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class PersonalInformation
	{
		/// <summary>
		/// Дата рождения пассажира в формате дд.ММ.гггг
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string DateOfBirth { get; set; }

		/// <summary>
		/// Место рождения, максимум 100 символов
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string PlaceOfBirth { get; set; }

		/// <summary>
		/// Гражданство пассажира
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Nationality { get; set; }

		/// <summary>
		/// Пол пассажира
		/// </summary>
		[DataMember(Order = 3)]
		public GenderTypes Gender { get; set; }

		/// <summary>
		/// Имя пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 4, EmitDefaultValue = false)]
		public string FirstName { get; set; }

		/// <summary>
		/// Отчество пассажира
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string MiddleName { get; set; }

		/// <summary>
		/// Фамилия пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 6, EmitDefaultValue = false)]
		public string LastName { get; set; }

		/// <summary>
		/// адрес пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 7, EmitDefaultValue = false)]
		public string Address { get; set; }

		/// <summary>
		/// телефон пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 8, EmitDefaultValue = false)]
		public string Phone { get; set; }

		/// <summary>
		/// Имя пассажира с транслитерацией
		/// </summary>
		[JsonIgnore]
		[IgnoreDataMember]
		public string FirstNameTL
		{
			get
			{
				return Transliteration.UARUStoENG(FirstName).ToUpper().Trim();
			}
		}

		/// <summary>
		/// Фамилия пассажира с транслитерацией
		/// </summary>
		[JsonIgnore]
		[IgnoreDataMember]
		public string LastNameTL
		{
			get { return Transliteration.UARUStoENG(LastName).ToUpper().Trim(); }
		}

		/// <summary>
		/// Отчество пассажира с транслитерацией
		/// </summary>
		[JsonIgnore]
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

		/// <summary>
		/// Получение возраста пассажира на указанную дату
		/// </summary>
		/// <param name="date">Дата, на момент которой требуется получить возраст пассажира</param>
		/// <returns>Возраст пассажира. 0 если дата рождения не указана</returns>
		public int GetAge(DateTime date)
		{
			if (string.IsNullOrEmpty(DateOfBirth))
			{
				return 0;
			}

			var dob = DateTime.ParseExact(DateOfBirth, Formats.DATE_FORMAT, null);
			var age = date.Year - dob.Year - (date.DayOfYear < dob.DayOfYear ? 1 : 0);

			return age;
		}
	}
}