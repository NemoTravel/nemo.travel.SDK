using AviaEntities.SharedElements;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.GetRequestCountInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetRequestCountInfoRQBody
	{
		[DataMember(Order = 0, IsRequired = false)]
		public DateTime StartDate { get; set; }

		[DataMember(Order = 1, IsRequired = false)]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// Список ИД внешних субагентств, информацию по банам которых необходимо получить
		/// </summary>
		[DataMember(Order = 2, IsRequired = false)]
		public SubAgencyIDHashSet SubAgenciesIDs { get; set; }

		/// <summary>
		/// Возвращает или задает ID агентства из Nemo Travel.
		/// </summary>
		[DataMember(Order = 3, IsRequired = false)]
		public int? NTAgencyID { get; set; }
	}
}
