using AviaEntities.SharedElements;
using GeneralEntities.PNRDataContent;
using GeneralEntities.Shared;
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

		/// <summary>
		/// Теги для ЦО
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		public TicketingRQBody Clone()
		{
			var result = new TicketingRQBody();

			result.BookID = BookID;
			if (RequestorTags != null)
			{
				result.RequestorTags = new TagList(RequestorTags);
			}
			if (DataItems != null)
			{
				result.DataItems = new PNRDataItemList(DataItems);
			}

			return result;
		}
	}
}