using GeneralEntities.Services.Ancillary;
using GeneralEntities.Services.Avia;
using GeneralEntities.Shared;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Содержит базовое описание услуг
	/// </summary>
	[KnownType(typeof(FlightService))]
	[KnownType(typeof(ArbitraryService))]
	[KnownType(typeof(InsuranceService))]
	[KnownType(typeof(AeroexpressService))]
	[KnownType(typeof(ServicePackageService))]
	[KnownType(typeof(FlightAncillaryService))]
	[KnownType(typeof(v1_1.Services.Ancillary.FlightAncillaryService))]
	[KnownType(typeof(HotelsService))]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public abstract class BaseService : ItemIdentification<int>
	{
		/// <summary>
		/// Код брони услуги в системе поставщика
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string SupplierID { get; set; }

		/// <summary>
		/// Признак онлайн/оффлайн услугой
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool IsOffline { get; set; }

		/// <summary>
		/// Статус услуги
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public PNRStatus Status { get; set; }

		/// <summary>
		/// Допстатусы услуги
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public PNRAdditionalStatusList SubStatus { get; set; }

		/// <summary>
		/// Ссылка на клиентов, которые приобрели данную услугу
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public RefList<int> TravellerRef { get; set; }


		/// <summary>
		/// Определение типа услуги
		/// </summary>
		/// <returns>Тип услуги</returns>
		public ServiceType GetServiceType()
		{
			if (this is FlightService)
			{
				return ServiceType.Avia;
			}

			throw new Exception("Невозможно определить тип услуги");
		}

		/// <summary>
		/// Выполняет проверку привязки данной услуги к определённому пассажиру
		/// </summary>
		/// <param name="travellerID">ИД пассажира</param>
		/// <returns>Признак привязки указанного пассажира к данной услуге</returns>
		public bool IsLinkedToTraveller(int travellerID)
		{
			return TravellerRef != null && TravellerRef.Contains(travellerID);
		}
	}
}