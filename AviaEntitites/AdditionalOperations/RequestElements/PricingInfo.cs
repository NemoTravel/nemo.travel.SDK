using AviaEntities.FlightSearch.RequestElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.RequestElements
{
	/// <summary>
	/// Содержит дополнительную информацию для получения актуальной цены перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class PricingInfo
	{
		/// <summary>
		/// Классы перелётов для каждого из сегментов перелёта (необходимо для результатов поиска по расписанию)
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public BookingClassCodesForSegments BookingClassCodes { get; set; }

		/// <summary>
		/// Пассажиры, для которых требуется искать цены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public List<Passenger> Passengers { get; set; }

		/// <summary>
		/// Код валюты, в которой должны вернуться цены результатов поиска
		/// </summary>
		[Obsolete("Валюта из запроса больше не должна учитываться.", true)]
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Искать только приватные тарифы
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool PrivateFaresOnly { get; set; }

		/// <summary>
		/// ВП, цены которого интересуют
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string ValidatingCompany { get; set; }

		/// <summary>
		/// Копирует все поля новыми объектами в переданный объект
		/// </summary>
		/// <param name="newObject"></param>
		public void CopyTo(PricingInfo newObject)
		{
			if (newObject != null)
			{
				if (BookingClassCodes != null)
				{
					newObject.BookingClassCodes = new BookingClassCodesForSegments(BookingClassCodes.ToDictionary(clCode => clCode.Key, clCode => clCode.Value));
				}

				if (Passengers != null)
				{
					newObject.Passengers = Passengers.ToList();
				}
				newObject.PrivateFaresOnly = PrivateFaresOnly;
				newObject.ValidatingCompany = ValidatingCompany;
			}
		}
	}
}