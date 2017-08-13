using AviaEntities.SharedElements.Ancillaries;
using AviaEntities.SharedElements.Ancillaries.ResponseElements;
using GeneralEntities;
using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Результат поиска допуслуг для определённого перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServicesSearchResult
	{
		/// <summary>
		/// Найденные допуслуги для указанного перелёта
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public AncillaryServices<AncillaryServiceRS> Services { get; set; }

		/// <summary>
		/// Список цен для найденных допуслуг
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public AncillaryServicesPrices Prices { get; set; }


		public AncillaryServicesSearchResult()
		{
			Services = new AncillaryServices<AncillaryServiceRS>();
			Prices = new AncillaryServicesPrices();
		}


		/// <summary>
		/// Добавить цену с учетом привязки к допуслуге
		/// </summary>
		/// <param name="amount">Стоимость</param>
		/// <param name="currency">Валюта стоимости</param>
		/// <param name="serviceRef">Номер допуслуги к которой применима данная цена</param>
		/// <param name="segmentRef">Номер сегмента к которому применима данная цена</param>
		/// <param name="travellerType">Тип пассажира к которому применима данная цена</param>
		public void AddPrice(double amount, string currency, int serviceRef, int segmentRef, PassTypes travellerType)
		{
			var price = Prices.Find(p =>
				p.Value.Value == amount &&
				p.Value.Currency == currency);

			if (price == null)
			{
				var money = new Money(amount, currency);

				price = new AncillaryServicePrice(money);
				Prices.Add(price);
			}

			price.TravellersTypes.Add(travellerType);

			if (!price.ServiceRef.Contains(serviceRef))
			{
				price.ServiceRef.Add(serviceRef);
			}

			if (!price.SegmentRef.Contains(segmentRef))
			{
				price.SegmentRef.Add(segmentRef);
			}
		}
	}
}