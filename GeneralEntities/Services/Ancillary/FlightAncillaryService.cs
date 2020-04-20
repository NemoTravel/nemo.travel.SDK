using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Описание авиа допуслуги.
	/// Сгрупированный относительно пассажира и данных допуслуги контейнер для нескольких допуслуг из ПНР
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FlightAncillaryService : BaseService
	{
		/// <summary>
		/// Признак бесплатности услуг (оформление EMD не требуется)
		/// </summary>
		[IgnoreDataMember]
		public bool IsFree { get; set; }


		/// <summary>
		/// Cсылка на сегмент
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int SegmentRef { get; set; }

		/// <summary>
		/// ИАТА код а/к, предоставляющей данную допуслугу
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string CompanyCode { get; set; }

		/// <summary>
		/// Описание допуслуг
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Код типа допуслуг
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string TypeCode { get; set; }

		/// <summary>
		/// Код типа допуслуг
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string RFIC { get; set; }

		/// <summary>
		/// Подкод типа допуслуг
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string RFISC { get; set; }

		/// <summary>
		/// Код SSRки данных допуслуг
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string SSRCode { get; set; }

		/// <summary>
		/// Текст SSRки данных допуслуг
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string SSRText { get; set; }

		/// <summary>
		/// Количество услуг
		/// </summary>
		[DataMember(Order = 9, IsRequired = true)]
		public int Quantity { get; set; }

		/// <summary>
		/// Группа
		/// </summary>
		[DataMember(Order = 10)]
		public string Group { get; set; }

		/// <summary>
		/// Суб группа
		/// </summary>
		[DataMember(Order = 11)]
		public string SubGroup { get; set; }

		public FlightAncillaryService DeepCopy()
		{
			FlightAncillaryService result = new FlightAncillaryService();

			result.CompanyCode = CompanyCode;
			result.Group = Group;
			result.ID = ID;
			result.IsFree = IsFree;
			result.IsOffline = IsOffline;
			result.Name = Name;
			result.Quantity = Quantity;
			result.RFIC = RFIC;
			result.RFISC = RFISC;
			result.SegmentRef = SegmentRef;
			result.SSRCode = SSRCode;
			result.SSRText = SSRText;
			result.Status = Status;
			result.SubGroup = SubGroup;
			result.SubStatus = SubStatus;
			result.SupplierID = SupplierID;
			result.TravellerRef = TravellerRef;
			result.TypeCode = TypeCode;

			return result;
		}
	}
}