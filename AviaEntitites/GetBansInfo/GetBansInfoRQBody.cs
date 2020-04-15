using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.GetBansInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetBansInfoRQBody
	{
		/// <summary>
		/// Список ИД внешних субагентств, информацию по банам которых необходимо получить
		/// </summary>
		[DataMember(Order = 0, IsRequired = false)]
		public SubAgencyIDHashSet SubAgenciesIDs { get; set; }

		/// <summary>
		/// Возвращает или задает ID агентства из Nemo Travel.
		/// </summary>
		[DataMember(Order = 1, IsRequired = false)]
		public int? NTAgencyID { get; set; }
	}
}