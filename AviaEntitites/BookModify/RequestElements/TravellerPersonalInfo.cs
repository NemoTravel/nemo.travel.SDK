using GeneralEntities;
using GeneralEntities.Client;
using System.Runtime.Serialization;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Новые персональные данные пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TravellerPersonalInfo
	{
		/// <summary>
		/// ФИО пассажира
		/// </summary>
		protected string newLastName, newFirstName, newMiddleName;

		/// <summary>
		/// Дата рождения
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string NewDateOfBirth { get; set; }

		/// <summary>
		/// Гражданство
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string NewNationality { get; set; }

		/// <summary>
		/// Пол
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public GenderTypes NewGender { get; set; }

		/// <summary>
		/// Имя
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public string NewFirstName
		{
			get { return newFirstName; }
			set { newFirstName = value; }
		}

		/// <summary>
		/// Фамилия
		/// </summary>
		[DataMember(IsRequired = true, Order = 4)]
		public string NewLastName
		{
			get { return newLastName; }
			set { newLastName = value; }
		}

		/// <summary>
		/// Отчество
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string NewMiddleName
		{
			get { return newMiddleName; }
			set { newMiddleName = value; }
		}

		/// <summary>
		/// Имя с транслитерацией
		/// </summary>
		[IgnoreDataMember]
		public string NewFirstNameTL
		{
			get
			{
				if (newFirstName != null)
				{
					return Transliteration.UARUStoENG(newFirstName).ToUpper();
				}
				else
				{
					return newFirstName;
				}
			}
		}

		/// <summary>
		/// Фамилия с транслитерацией
		/// </summary>
		[IgnoreDataMember]
		public string NewLastNameTL
		{
			get
			{
				if (newLastName != null)
				{
					return Transliteration.UARUStoENG(newLastName).ToUpper();
				}
				else
				{
					return newLastName;
				}
			}
		}

		/// <summary>
		/// Отчество с транслитерацией
		/// </summary>
		[IgnoreDataMember]
		public string NewMiddleNameTL
		{
			get
			{
				if (newMiddleName != null)
				{
					return Transliteration.UARUStoENG(newMiddleName).ToUpper();
				}
				else
				{
					return newMiddleName;
				}
			}
		}

		/// <summary>
		/// Создаёт новый объект персональной информации для модификации, заполняя недостающие данные старыми данными
		/// </summary>
		/// <param name="oldInfo">Старые персональные данные пассажиров</param>
		/// <returns>Созданный объект</returns>
		public PersonalInformation CreateTravellerForModify(PersonalInformation oldInfo)
		{
			PersonalInformation res = new PersonalInformation();

			if (NewDateOfBirth != null)
			{
				res.DateOfBirth = NewDateOfBirth;
			}
			else
			{
				res.DateOfBirth = oldInfo.DateOfBirth;
			}

			if (NewFirstName != null)
			{
				res.FirstName = NewFirstNameTL;
			}
			else
			{
				res.FirstName = oldInfo.FirstNameTL;
			}

			if (NewGender != null)
			{
				res.Gender = (GenderTypes)NewGender;
			}
			else
			{
				res.Gender = oldInfo.Gender;
			}

			if (NewLastName != null)
			{
				NewLastName = NewLastNameTL.ToUpper();
				res.LastName = NewLastName;
			}
			else
			{
				res.LastName = oldInfo.LastNameTL;
			}

			if (NewMiddleName != null)
			{
				res.MiddleName = NewMiddleNameTL;
			}
			else
			{
				res.MiddleName = oldInfo.MiddleName;
			}

			if (NewNationality != null)
			{
				res.Nationality = NewNationality;
			}
			else
			{
				res.Nationality = oldInfo.Nationality;
			}

			return res;
		}
	}
}