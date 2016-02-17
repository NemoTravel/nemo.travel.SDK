using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic.FFPPartnership
{
	/// <summary>
	/// Содержит список партнеров по компаниям
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AirlinePartnerBlock
	{
		/// <summary>
		/// IATA код авиакомпании
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Airline { get; set; }

		/// <summary>
		/// Признак, что вместо списка используются все АК
		/// </summary>
		[DataMember(Order = 2)]
		public bool AllAirlines { get; set; }

		/// <summary>
		/// Список партнеров
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public AirlinePartners Partners { get; set; }
	}
}