using AviaEntities.BookFlight.RequestElements;
using AviaEntities.BookModify.RequestElements;
using GeneralEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Информация о пассажире, хранимая по результатам создания брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class BookedTraveller : Traveller
	{
		/// <summary>
		/// Забронированные места для данного перелёта данного пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 13, EmitDefaultValue = false)]
		public BookedSeatList Seats { get; set; }

		/// <summary>
		/// Номера билетов данного пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 14, EmitDefaultValue = false)]
		public TicketList Tickets { get; set; }

		/// <summary>
		/// Возможно ли редактирование пассажира (для ГДС SpecialFares)
		/// </summary>
		//[DataMember(IsRequired = false, Order = 15, EmitDefaultValue = false)]
		[IgnoreDataMember]
		[JsonProperty]
		public bool IsEdit { get; set; }

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public BookedTraveller()
		{}

		/// <summary>
		/// Заполнение общих с пассажиром из запроса полей 
		/// </summary>
		/// <param name="basePass">Базовый класс для пассажиров</param>
		public BookedTraveller(Traveller basePass)
		{
			ContactInfo = basePass.ContactInfo;
			DocumentInfo = basePass.DocumentInfo;
			IsContact = basePass.IsContact;
			LinkedTo = basePass.LinkedTo;
			PersonalInfo = basePass.PersonalInfo;
			Type = basePass.Type;
			ArrAddress = basePass.ArrAddress;
			LoyaltyCards = basePass.LoyaltyCards;
			Num = basePass.Num;
			VisaInfo = basePass.VisaInfo;

			if (DocumentInfo != null)
			{
				DocumentInfo.DocNum = Transliteration.UARUStoENG(basePass.DocumentInfo.CleanDocNum).ToUpper();
			}

			if (VisaInfo != null)
			{
				VisaInfo.BirthCity = Transliteration.UARUStoENG(basePass.VisaInfo.BirthCity).ToUpper();
				VisaInfo.IssuePlace = Transliteration.UARUStoENG(basePass.VisaInfo.IssuePlace).ToUpper();
			}

			if (ArrAddress != null)
			{
				ArrAddress.City = Transliteration.UARUStoENG(basePass.ArrAddress.City).ToUpper();
				ArrAddress.State = Transliteration.UARUStoENG(basePass.ArrAddress.State).ToUpper();
				ArrAddress.StreetAddress = Transliteration.UARUStoENG(basePass.ArrAddress.StreetAddress).ToUpper();
			}
		}
		
		/// <summary>
		/// Заполнение базовой информации о пассажире, на основании данных из запроса
		/// </summary>
		/// <param name="passengerFromRequest"></param>
		public void Fill(Traveller passengerFromRequest, bool latinRegistration = true)
		{
			Num = passengerFromRequest.Num;
			Type = passengerFromRequest.Type;
			IsContact = passengerFromRequest.IsContact;
			LinkedTo = passengerFromRequest.LinkedTo;
			PersonalInfo = passengerFromRequest.PersonalInfo;
			DocumentInfo = passengerFromRequest.DocumentInfo;
			VisaInfo = passengerFromRequest.VisaInfo;
			ArrAddress = passengerFromRequest.ArrAddress;
			ContactInfo = passengerFromRequest.ContactInfo;

			if (latinRegistration)
			{
				if (DocumentInfo != null)
				{
					DocumentInfo.DocNum = Transliteration.UARUStoENG(passengerFromRequest.DocumentInfo.CleanDocNum).ToUpper();
				}

				if (VisaInfo != null)
				{
					VisaInfo.BirthCity = Transliteration.UARUStoENG(passengerFromRequest.VisaInfo.BirthCity).ToUpper();
					VisaInfo.IssuePlace = Transliteration.UARUStoENG(passengerFromRequest.VisaInfo.IssuePlace).ToUpper();
				}

				if (ArrAddress != null)
				{
					ArrAddress.City = Transliteration.UARUStoENG(passengerFromRequest.ArrAddress.City).ToUpper();
					ArrAddress.State = Transliteration.UARUStoENG(passengerFromRequest.ArrAddress.State).ToUpper();
					ArrAddress.StreetAddress = Transliteration.UARUStoENG(passengerFromRequest.ArrAddress.StreetAddress).ToUpper();
				}
			}
		}

		/// <summary>
		/// Выполняет модификацию хранимой информации о предпочитаемых местах пассажира
		/// </summary>
		/// <param name="placeInfo">Новая информация о предпочитаемых местах</param>
		/// <param name="specificPlaceModified">Ассоциативный массив индикаторов какие из мест были модифицированы</param>
		public void ModifyPlaceInfo(List<TravellerPreferedPlace> placeInfo, Dictionary<int, bool> specificPlaceModified)
		{
			PreferedPlace tmpPlace, oldPlaceInfo;

			if (placeInfo != null && placeInfo.Count > 0)
			{
				foreach (TravellerPreferedPlace newPlaceInfo in placeInfo)
				{
					if (PreferedPlaces == null)
					{
						PreferedPlaces = new List<PreferedPlace>();
					}

					//находим старую информацию о предпочитаемом месте
					oldPlaceInfo = PreferedPlaces.Find(place => place.SegNumber == newPlaceInfo.SegNum);

					//если есть новая информация о неконкретном (не через карту мест) предпочитаемом месте
					if (newPlaceInfo.NewNotSpecificPlace != null)
					{
						if (oldPlaceInfo != null)
						{
							oldPlaceInfo.SmokingAllowed = newPlaceInfo.NewNotSpecificPlace.SmokingAllowed;
							oldPlaceInfo.Location = newPlaceInfo.NewNotSpecificPlace.Location;
						}
						else
						{
							tmpPlace = new PreferedPlace();
							tmpPlace.SmokingAllowed = newPlaceInfo.NewNotSpecificPlace.SmokingAllowed;
							tmpPlace.Location = newPlaceInfo.NewNotSpecificPlace.Location;
							PreferedPlaces.Add(tmpPlace);
						}
					}

					//если есть новая информация о конкретном месте и оно было модифицировано
					if (newPlaceInfo.NewSpecificPlace != null && specificPlaceModified[newPlaceInfo.SegNum])
					{
						if (oldPlaceInfo != null)
						{
							oldPlaceInfo.PlaceNumber = newPlaceInfo.NewSpecificPlace.PlaceNumber;
							oldPlaceInfo.RowNumber = newPlaceInfo.NewSpecificPlace.RowNumber;
						}
						else
						{
							tmpPlace = new PreferedPlace();
							tmpPlace.PlaceNumber = newPlaceInfo.NewSpecificPlace.PlaceNumber;
							tmpPlace.RowNumber = newPlaceInfo.NewSpecificPlace.RowNumber;
							PreferedPlaces.Add(tmpPlace);
						}
					}
				}
			}
		}
	}
}