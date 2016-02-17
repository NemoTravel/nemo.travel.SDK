using AviaEntities.SharedElements;
using GeneralEntities.PNRDataContent;
using System.Runtime.Serialization;

namespace AviaEntities.v2.Ticketing
{
	/// <summary>
	/// Тело запроса выписки брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "TicketingRQBody_2_0")]
	public class TicketingRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Унифицированные данные брони
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PNRDataItemList DataItems { get; set; }
	}
}