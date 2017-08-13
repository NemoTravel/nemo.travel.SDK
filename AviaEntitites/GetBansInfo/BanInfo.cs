using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.GetBansInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BanInfo
	{
		/// <summary>
		/// ИД внешнего субагентства
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int SubAgencyID { get; set; }

		/// <summary>
		/// Тип бана
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public BanType BanType { get; set; }

		/// <summary>
		/// Дополнительная информация о бане
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public AdditionalBanInfo AdditionalBanInfo { get; set; }
	}
}