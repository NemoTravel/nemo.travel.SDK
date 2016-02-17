using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.GetBookHistory
{
	/// <summary>
	/// Содержит историю опеределённой брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetBookHistoryRSBody : OnlyBookIDElement
	{
		/// <summary>
		/// Код ПНРа, по которому создана бронь
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string PNRCode { get; set; }

		/// <summary>
		/// История ПНРа
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public BookHistoryElementList HistoryElements { get; set; }
	}
}