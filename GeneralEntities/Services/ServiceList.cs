using GeneralEntities.Services.Ancillary;
using GeneralEntities.Services.Avia;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Список услуг
	/// </summary>
	[KnownType(typeof(FlightService))]
	[KnownType(typeof(ArbitraryService))]
	[KnownType(typeof(InsuranceService))]
	[KnownType(typeof(AeroexpressService))]
	[KnownType(typeof(ServicePackageService))]
	[KnownType(typeof(FlightAncillaryService))]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Service")]
	public class ServiceList : List<BaseService>
	{
		public ServiceList()
		{ }

		public ServiceList(IEnumerable<BaseService> enumerable)
			: base(enumerable)
		{ }
	}
}