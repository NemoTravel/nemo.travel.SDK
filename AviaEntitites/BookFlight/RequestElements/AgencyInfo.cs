using GeneralEntities;
using GeneralEntities.Client;
using GeneralEntities.Traveller;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.RequestElements
{
	/// <summary>
	/// Информации об агентстве
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class AgencyInfo
	{
		/// <summary>
		/// Идентификатор агентства
		/// </summary>
		public int? ID { get; set; }
		
		/// <summary>
		/// Название агентства
		/// </summary>
		[DataMember(IsRequired = false, Order = 0, EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Контактный телефон агентства
		/// </summary>
		[DataMember(IsRequired = false, Order = 1, EmitDefaultValue = false)]
		public Telephone Telephone { get; set; }

		/// <summary>
		/// Адрес агентства
		/// </summary>
		[DataMember(IsRequired = false, Order = 2, EmitDefaultValue = false)]
		public ArrivalAddress Address { get; set; }

		/// <summary>
		/// Создание нового объекта из старого с учётом требований транслитерации
		/// </summary>
		/// <param name="old">Старая информация об агентстве</param>
		/// <param name="latinRegistration">Необходимость транслитерации</param>
		public AgencyInfo(AgencyInfo old, bool latinRegistration = true)
		{
			Address = old.Address;
			if (latinRegistration)
			{
				Name = Transliteration.CyrillicToLatin(old.Name).ToUpper();

				if (Address != null)
				{
					if (!string.IsNullOrEmpty(Address.City))
					{
						Address.City = Transliteration.CyrillicToLatin(Address.City).ToUpper();
					}

					if (!string.IsNullOrEmpty(Address.State))
					{
						Address.State = Transliteration.CyrillicToLatin(Address.State).ToUpper();
					}

					if (!string.IsNullOrEmpty(Address.StreetAddress))
					{
						Address.StreetAddress = Transliteration.CyrillicToLatin(Address.StreetAddress).ToUpper();
					}
				}
			}
			else
			{
				Name = old.Name;
			}
		}

		/// <summary>
		/// Создание нового объекта
		/// </summary>
		public AgencyInfo()
		{ }
	}
}