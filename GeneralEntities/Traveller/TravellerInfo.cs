using GeneralEntities.Client;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Traveller
{
	/// <summary>
	/// Информация о путешественнике
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TravellerInfo : ClientInfo
	{
		/// <summary>
		/// Номер пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public int Num { get; set; }

		/// <summary>
		/// Тип пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public PassTypes Type { get; set; }

		/// <summary>
		/// Индикатор контактного пассажира
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool IsContact { get; set; }

		/// <summary>
		/// Привязка пассажира к другому пассажиру
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public int LinkedTo { get; set; }

		/// <summary>
		/// Паспортные или иного документа данные пассажира
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public DocumentInformation DocumentInfo { get; set; }

		/// <summary>
		/// Информация о визе
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public VisaInformation VisaInfo { get; set; }

		/// <summary>
		/// Информация об адресе пребывания
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public ArrivalAddress ArrAddress { get; set; }

		/// <summary>
		/// Информация о карточках часто летающего пассажира, для данного пассажира
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public List<LoyaltyCard> LoyaltyCards { get; set; }
	}
}