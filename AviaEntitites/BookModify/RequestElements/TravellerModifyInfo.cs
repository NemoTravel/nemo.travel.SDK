using System.Collections.Generic;
using System.Runtime.Serialization;
using AviaEntities.BookFlight.RequestElements;
using AviaEntities.BookFlight.ResponseElements;
using GeneralEntities.Traveller;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Новая информация о пассажире
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TravellerModifyInfo
	{
		/// <summary>
		/// Номер пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int Num { get; set; }

		/// <summary>
		/// Новая информация о предпочитаемых местах
		/// </summary>
		[DataMember(IsRequired = false, Order = 1)]
		public TravellerPreferedPlaceList PreferedPlaces { get; set; }

		/// <summary>
		/// Новая информация о документе
		/// </summary>
		[DataMember(IsRequired = false, Order = 2)]
		public DocumentInformation DocumentInfo { get; set; }

		/// <summary>
		/// Новая информация о визе
		/// </summary>
		[DataMember(IsRequired = false, Order = 3)]
		public VisaInformation VisaInfo { get; set; }

		/// <summary>
		/// Новая информация об адресе пребывания
		/// </summary>
		[DataMember(IsRequired = false, Order = 4)]
		public ArrivalAddress ArrAddress { get; set; }

		/// <summary>
		/// Новые персональные данный пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 5)]
		public TravellerPersonalInfo PersonalInfo { get; set; }

		/// <summary>
		/// Новое предпочитаемое питание
		/// </summary>
		[DataMember(IsRequired = false, Order = 6)]
		public MealTypes? Meal { get; set; }

		/// <summary>
		/// Новая контактная информация пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 7)]
		public TravellerContactInfo ContactInfo { get; set; }

		/// <summary>
		/// Создание информации о пассажире для модификации
		/// </summary>
		/// <param name="oldInfo">Старая информация о пассажире</param>
		/// <returns>Новая информация о пассажире</returns>
		public Traveller CreateTravellerForModify(BookedTraveller oldInfo)
		{
			Traveller res = new Traveller();
			res.Type = oldInfo.Type;
			res.Num = oldInfo.Num;

			if (ArrAddress != null)
			{
				res.ArrAddress = ArrAddress;
			}

			if (ContactInfo != null)
			{
				res.ContactInfo = ContactInfo.CreateContactForModify(oldInfo.ContactInfo);
			}

			if (DocumentInfo != null)
			{
				res.DocumentInfo = DocumentInfo;
			}

			if (Meal.HasValue)
			{
				res.Meal = Meal.ToString();
			}

			if (PersonalInfo != null)
			{
				res.PersonalInfo = PersonalInfo.CreateTravellerForModify(oldInfo.PersonalInfo);
			}

			if (PreferedPlaces != null && PreferedPlaces.Count > 0)
			{
				res.PreferedPlaces = new List<PreferedPlace>();

				foreach (var place in PreferedPlaces)
				{
					PreferedPlace newPlace = place.CreatePlaceForModify();

					if (newPlace != null)
					{
						res.PreferedPlaces.Add(newPlace);
					}
				}
			}

			if (VisaInfo != null)
			{
				res.VisaInfo = VisaInfo;
			}

			return res;
		}
	}
}