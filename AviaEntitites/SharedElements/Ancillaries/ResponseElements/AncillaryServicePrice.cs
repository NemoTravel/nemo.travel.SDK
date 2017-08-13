using GeneralEntities;
using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	/// <summary>
	/// Расширенная цена допуслуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServicePrice
	{
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
		/// Типы пассажиров к которым применима данная цена
		/// </summary>
		[DataMember(Order = 3)]
		public HashSet<PassTypes> TravellersTypes { get; set; }


		public AncillaryServicePrice()
		{
			ServiceRef = new RefList<int>();
			SegmentRef = new RefList<int>();
			TravellersTypes = new HashSet<PassTypes>();
		}

		public AncillaryServicePrice(Money money) : this()
		{
			Value = money;
		}
	}
}