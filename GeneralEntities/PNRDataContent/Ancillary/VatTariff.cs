using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class VatTariff : PercentCurrencyAmount
	{
		[DataMember(Order = 0)]
		public RefList<int> SegmentRefs { get; set; }


		public VatTariff() { }

		public VatTariff(decimal amount, string currency, double? percent, IReadOnlyCollection<int> segmentRefs) : base(amount, currency, percent)
		{
			SegmentRefs = new RefList<int>(segmentRefs);
		}


		public VatTariff Copy()
		{
			var other = new VatTariff();

			base.CopyTo(other);

			if (SegmentRefs != null)
			{
				other.SegmentRefs = new RefList<int>(SegmentRefs);
			}

			return other;
		}
	}
}