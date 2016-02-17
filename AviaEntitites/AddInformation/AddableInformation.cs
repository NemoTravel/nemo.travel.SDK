using AviaEntities.BookFlight.RequestElements;
using GeneralEntities.Client;
using GeneralEntities.Traveller;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AddInformation
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AddableInformation
	{
		/// <summary>
		/// Номер пассажира, для которого будут добавляться данные
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int PassNumber { get; set; }

		/// <summary>
		/// Паспортные или иного документа данные пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 1)]
		public DocumentInformation DocumentInfo { get; set; }

		/// <summary>
		/// Информация о визе
		/// </summary>
		[DataMember(IsRequired = false, Order = 2)]
		public VisaInformation VisaInfo { get; set; }

		/// <summary>
		/// Информация об адресе пребывания
		/// </summary>
		[DataMember(IsRequired = false, Order = 3)]
		public ArrivalAddress ArrAddress { get; set; }

		/// <summary>
		/// Информация о карточках часто летающего пассажира, для данного пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 4)]
		public List<LoyaltyCard> LoyaltyCards { get; set; }

		/// <summary>
		/// Контактная информация пассажира
		/// </summary>
		[DataMember(IsRequired = false, Order = 5)]
		public ContactInfo ContactInfo { get; set; }

		/// <summary>
		/// Предпочитаемые места в самолёте
		/// </summary>
		[DataMember(IsRequired = false, Order = 6)]
		public List<PreferedPlace> PreferedPlaces { get; set; }

		/// <summary>
		/// Предпочитаемое питание пассажира в самолёте
		/// </summary>
		[DataMember(IsRequired = false, Order = 7)]
		public MealTypes? Meal { get; set; }
	}
}