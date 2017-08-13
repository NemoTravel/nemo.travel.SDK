using AviaEntities.SharedElements;
using AviaEntities.v1_1.AdditionalOperations.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightRepricingRQBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Дополнительная информация для получения актуальной цены перелёта
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public PricingInfo PricingInfo { get; set; }
	}
}