using SharedAssembly.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	/// <summary>
	/// Обобщенный контейнер цен допуслуг
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServicesPrices : List<AncillaryServicePrice>
	{
		/// <summary>
		/// Добавление цены с устранением одинаковых по стоимости и типу пассажира цен
		/// </summary>
		/// <param name="price">Цена допуслуги</param>
		public void AddDistinctPassType(AncillaryServicePrice price)
		{
			var samePriceExists = Exists(p =>
				p.Value.Value == price.Value.Value &&
				p.Value.Currency == price.Value.Currency &&
				p.SegmentRef.SequenceEqual(price.SegmentRef) &&
				p.ServiceRef.SequenceEqual(price.ServiceRef) &&
				p.TravellersTypes.SequenceEqual(price.TravellersTypes) &&
				p.TravellerRef.ElementsEquals(price.TravellerRef));

			if (!samePriceExists)
			{
				Add(price);
			}
		}
	}
}