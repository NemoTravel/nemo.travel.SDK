using System.Collections.Generic;
using System.Linq;

namespace GeneralEntities.PriceContent
{
	public static class PassengerTypePriceBreakdownListExtension
	{
		/// <summary>
		/// Получение авиа тарифов для определённого пассажира
		/// </summary>
		/// <param name="travellerID">ID пассажира, чьи тарифы требуется получить</param>
		public static IEnumerable<AirTariff> GetAirTariffsForTraveller(this IReadOnlyCollection<PassengerTypePriceBreakdown> breakdowns, int travellerID)
		{
			if (breakdowns != null)
			{
				return breakdowns
					.Where(ptc => ptc.IsLinkedToTraveller(travellerID) && ptc.Tariffs != null)
					.SelectMany(ptp => ptp.Tariffs.OfType<AirTariff>());
			}

			return Enumerable.Empty<AirTariff>();
		}
	}
}