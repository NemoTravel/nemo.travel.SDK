using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Traveller
{
	/// <summary>
	/// Карточка часто летающего пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class LoyaltyCard
	{
		/// <summary>
		/// Код авиаперевозчика, выдавшего карточку
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string CompanyCode { get; set; }

		/// <summary>
		/// Номер карты
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string Number { get; set; }
	}
}