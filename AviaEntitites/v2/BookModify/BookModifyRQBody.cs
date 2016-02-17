using AviaEntities.SharedElements;
using GeneralEntities.ModifyContent;
using System.Runtime.Serialization;

namespace AviaEntities.v2.BookModify
{
	/// <summary>
	/// Содержит описание запроса на модификацию брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookModifyRQBody_2_0")]
	public class BookModifyRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Модификация данных пассажира
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public ModifyTravellerInformationList Travellers { get; set; }

		/// <summary>
		/// Модификация перелёта
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public ModifyFlightService Flight { get; set; }

		/// <summary>
		/// Контент брони
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public ModifyPNRDataItemList DataItems { get; set; }
	}
}