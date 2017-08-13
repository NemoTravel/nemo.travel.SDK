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
	}
}