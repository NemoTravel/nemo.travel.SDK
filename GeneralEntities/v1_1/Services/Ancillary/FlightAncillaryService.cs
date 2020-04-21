using GeneralEntities.Services;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.v1_1.Services.Ancillary
{
	/// <summary>
	/// Описание авиа допуслуги v1.1
	/// </summary>
	[DataContract(Namespace = "http://nemo.travel/STL", Name = "FlightAncillaryService_1_1")]
	public class FlightAncillaryService : BaseService
	{
		/// <summary>
		/// Признак бесплатности услуг (оформление EMD не требуется)
		/// </summary>
		[IgnoreDataMember]
		public bool IsFree { get; set; }


		/// <summary>
		/// Cсылки на сегменты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public RefList<int> SegmentRef { get; set; }

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


		/// <summary>
		/// Выполняет проверку привязки данной услуги к определённому сегменту
		/// </summary>
		/// <param name="segmentID">ИД сегмента</param>
		/// <returns>Признак привязки указанного сегмента к данной услуге</returns>
		public bool IsLinkedToSegment(int segmentID)
		{
			return SegmentRef != null && SegmentRef.Contains(segmentID);
		}

		public FlightAncillaryService DeepCopy()
		{
			var result = new FlightAncillaryService();

			result.CompanyCode = CompanyCode;
			result.Group = Group;
			result.ID = ID;
			result.SupplierID = SupplierID;
			result.IsFree = IsFree;
			result.IsOffline = IsOffline;
			result.Name = Name;
			result.Quantity = Quantity;
			result.RFIC = RFIC;
			result.RFISC = RFISC;
			result.SSRCode = SSRCode;
			result.SSRText = SSRText;
			result.Status = Status;
			result.SubGroup = SubGroup;
			result.SubStatus = SubStatus;
			result.TypeCode = TypeCode;

			if (TravellerRef != null)
			{
				result.TravellerRef = new RefList<int>(TravellerRef);
			}

			if (SegmentRef != null)
			{
				result.SegmentRef = new RefList<int>(SegmentRef);
			}

			return result;
		}
	}
}