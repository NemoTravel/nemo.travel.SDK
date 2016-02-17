using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Описание авиа допуслуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FlightAncillaryService : BaseService
	{
		/// <summary>
		/// Ссылка на сегменты перелёта, для которых приобрели данную услугу
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public List<int> SegmentRef { get; set; }

		/// <summary>
		/// Номер допуслуги, по которому её можно будет купить
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int Number { get; set; }

		/// <summary>
		/// Код типа допуслуги
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string TypeCode { get; set; }

		/// <summary>
		/// Описание допуслуги
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// ИАТА код а/к, предоставляющей данную допуслугу
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public string CompanyCode { get; set; }

		/// <summary>
		/// Признак необходимости оплаты ГДС процессингом данной услуги
		/// </summary>
		[DataMember(Order = 5, IsRequired = true)]
		public bool CCFOPRequired { get; set; }

		/// <summary>
		/// Код SSRки, которую необходимо добавить в ПНР в случае покупки данной допуслуги
		/// </summary>
		[DataMember(Order = 6, IsRequired = true)]
		public string RequieredSSR { get; set; }

		/// <summary>
		/// Код SSRки, для которое требуется описание от юзера
		/// </summary>
		[DataMember(Order = 7, IsRequired = true)]
		public string RequierDescriptionForSSR { get; set; }
	}
}