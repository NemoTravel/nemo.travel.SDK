using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class SellingPointDescriptionDataItem
	{
		/// <summary>
		/// ИД внешенго субагентства
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int? SubAgencyID { get; set; }

		public SellingPointDescriptionDataItem Copy()
		{
			var result = new SellingPointDescriptionDataItem();

			result.SubAgencyID = SubAgencyID;

			return result;
		}
	}
}
