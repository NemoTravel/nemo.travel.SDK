using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Описание услуги аэроэкспресса
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class AeroexpressService : BaseService
	{
		/// <summary>
		/// Ссылка на сегменты перелёта, для которых приобрели данную услугу
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public List<int> SegmentRef { get; set; }

		/// <summary>
		/// Название станции отправления/прибытия
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string StationName { get; set; }

		/// <summary>
		/// Признак типа направления - из/в аэропорт
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public bool ToAirport { get; set; }

		/// <summary>
		/// УРЛ к документу/билету
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string DocumentURL { get; set; }
	}
}