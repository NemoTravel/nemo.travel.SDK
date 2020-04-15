using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	/// <summary>
	/// Цена допуслуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BaseAncillaryServicePrice
	{

		/// <summary>
		/// Объект стоимости
		/// </summary>
		[DataMember(Order = 0)]
		public Money Value { get; set; }

		/// <summary>
		/// Ссылки на услуги, для которых применима данная цена
		/// </summary>
		[DataMember(Order = 1)]
		public RefList<int> ServiceRef { get; set; }

		/// <summary>
		/// Ссылки на сегменты, к которым применима данная цена
		/// </summary>
		[DataMember(Order = 2)]
		public RefList<int> SegmentRef { get; set; }

		/// <summary>
		/// Ссылка на карточку лояльности, для которой применима данная цена
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public RefList<long> LoyaltyCardRef { get; set; }

		public BaseAncillaryServicePrice()
		{
			ServiceRef = new RefList<int>();
			SegmentRef = new RefList<int>();
		}

		public BaseAncillaryServicePrice(double amount, string currency) : this()
		{
			Value = new Money(amount, currency);
		}
	}
}
