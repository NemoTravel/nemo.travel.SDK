using System.Runtime.Serialization;

namespace AviaEntities.GetBansInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalBanInfo
	{
		/// <summary>
		/// Количество запросов поисков
		/// </summary>
		[DataMember(Order = 0, IsRequired = false, EmitDefaultValue = false)]
		public int? Searches { get; set; }

		/// <summary>
		/// Количество поисков на одну выписку
		/// </summary>
		[DataMember(Order = 1, IsRequired = false, EmitDefaultValue = false)]
		public double? SearchesPerTicket { get; set; }
	}
}