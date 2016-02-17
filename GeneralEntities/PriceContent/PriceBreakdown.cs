using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Описание составной части цены брони/заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PriceBreakdown
	{
		/// <summary>
		/// Ссылка на услугу
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RefList<int> ServiceRef { get; set; }

		/// <summary>
		/// Ссылка на сегмент услуги
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public RefList<int> SegmentRef { get; set; }

		/// <summary>
		/// Полная цена
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public Money TotalPrice { get; set; }

		/// <summary>
		/// ВП
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Признак возвратности по данной цене
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public RefundableEnum Refundable { get; set; }

		/// <summary>
		/// Признак того, что в цене участвуют некие приватные тарифы
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool PrivateFareInd { get; set; }

		/// <summary>
		/// Расклад формирования цены по типам пассажиров
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public PassengerTypePriceBreakdownList PassengerTypePriceBreakdown { get; set; }



		/// <summary>
		/// Проверяет принадлежность цены определённой услуге
		/// </summary>
		/// <param name="serviceID">ИД услуги, принадлежность к которой требуется проверить</param>
		/// <returns>Принаделжность данной цены к указанной услуге</returns>
		public bool IsLinkedToService(int serviceID)
		{
			return ServiceRef == null || ServiceRef.Contains(serviceID);
		}

		/// <summary>
		/// Проверяет принадлежность цены определённому сегменту в услуге
		/// </summary>
		/// <param name="serviceID">ИД сегмента в услуге, принадлежность к которому требуется проверить</param>
		/// <returns>Принаделжность данной цены к указанному сегменту в услуге</returns>
		public bool IsLinkedToSegment(int segmentID)
		{
			return SegmentRef == null || SegmentRef.Contains(segmentID);
		}
	}
}