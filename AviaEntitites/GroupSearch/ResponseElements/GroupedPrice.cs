using AviaEntities.FlightSearch.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию о сгруппированных ценах
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GroupedPrice : Price
	{
		/// <summary>
		/// ИД пакета реквизитов, из которого была полученая данная цена
		/// </summary>
		[DataMember(IsRequired = true, Order = 4)]
		public int SourceID { get; set; }

		/// <summary>
		/// Валидирующий перевозчик для данной цены
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Информация о классах перелёта, к которым применяется данная цена
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public BookingClassList BookingClassInfo { get; set; }

		/// <summary>
		/// Заполнение информации о цене на основании несгруппированной пары цена + перелёт
		/// </summary>
		/// <param name="priceInfoContent">Информация о цене</param>
		/// <param name="segments">Сегменты перелёта</param>
		public void Fill(Price priceInfoContent, List<CompleteSegment> segments)
		{
			PrivateFareInd = priceInfoContent.PrivateFareInd;
			Refundable = priceInfoContent.Refundable;
			TicketTimeLimit = priceInfoContent.TicketTimeLimit;

			RulesInfos = priceInfoContent.RulesInfos;
			PassengerFares = priceInfoContent.PassengerFares;
			BookingClassInfo = new BookingClassList();

			foreach (var segment in segments)
			{
				var tmp = new BookingClassInformation(segment);
				BookingClassInfo.Add(tmp);
			}
		}
	}
}