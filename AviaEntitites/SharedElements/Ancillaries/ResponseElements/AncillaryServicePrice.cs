using GeneralEntities;
using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	/// <summary>
	/// Цена допуслуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServicePrice : BaseAncillaryServicePrice
	{
		/// <summary>
		/// Типы пассажиров к которым применима данная цена
		/// </summary>
		[DataMember(Order = 0)]
		public HashSet<PassTypes> TravellersTypes { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public RefList<int> TravellerRef { get; set; }


		public AncillaryServicePrice()
		{
			TravellersTypes = new HashSet<PassTypes>();
		}

		public AncillaryServicePrice(double amount, string currency) : base(amount, currency)
		{
			TravellersTypes = new HashSet<PassTypes>();
		}


		public AncillaryServicePrice DeepCopy()
		{
			var result = new AncillaryServicePrice();

			result.Value = Value?.Copy();
			result.ServiceRef = ServiceRef?.DeepCopy();
			result.SegmentRef = SegmentRef?.DeepCopy();
			result.LoyaltyCardRef = LoyaltyCardRef?.DeepCopy();
			result.TravellersTypes = TravellersTypes != null ? new HashSet<PassTypes>(TravellersTypes) : null;
			result.TravellerRef = TravellerRef?.DeepCopy();

			return result;
		}
	}
}