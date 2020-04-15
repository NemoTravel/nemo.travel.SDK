using AviaEntities.FlightSearch.RequestElements;
using AviaEntities.ScheduleSearch.RequestElements;
using GeneralEntities.PNRDataContent;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch
{
	/// <summary>
	/// Тело запроса поиска перелётов по расписанию
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ScheduleSearchRQBody
	{
		/// <summary>
		/// Содержит техническую информацию о сегметах запрашиваемого перелёта
		/// (время вылета, прямой или с пересадками и т.д.)
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public ScheduleFlightDirection RequestedFlightInfo { get; set; }

		/// <summary>
		/// Допольнительный условия/ограничея, накладываемые на поиск перелётов
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public v1_2.SearchFlights.RequestElements.AdditionalSearchInfo Restrictions { get; set; }

		/// <summary>
		/// Данные конечного пользователя
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public EndUserDataDataItem EndUserData { get; set; }


		/// <summary>
		/// Выполняет полное копирование объекта, реализация интерфейса ICloneable
		/// </summary>
		/// <returns>Результат копирования</returns>
		public ScheduleSearchRQBody Clone()
		{
			var result = new ScheduleSearchRQBody();

			result.RequestedFlightInfo = new ScheduleFlightDirection();
			result.RequestedFlightInfo.ODPair = RequestedFlightInfo.ODPair.FullCopy();

			result.RequestedFlightInfo.Direct = RequestedFlightInfo.Direct;
			result.RequestedFlightInfo.SubType = RequestedFlightInfo.SubType;

			if (Restrictions != null)
			{
				result.Restrictions = new v1_2.SearchFlights.RequestElements.AdditionalSearchInfo();
				result.Restrictions.ClassPreference = Restrictions.ClassPreference;
				result.Restrictions.PrivateFaresOnly = Restrictions.PrivateFaresOnly;
				result.Restrictions.SourcePreference = Restrictions.SourcePreference;
				result.Restrictions.MaxConnectionTime = Restrictions.MaxConnectionTime;
				result.Restrictions.ResultsGrouping = Restrictions.ResultsGrouping;
				result.Restrictions.MaxResultCount = Restrictions.MaxResultCount;
				result.Restrictions.MaxConnections = Restrictions.MaxConnections;

				if (Restrictions.CompanyFilter != null)
				{
					result.Restrictions.CompanyFilter = new List<Company>();
					foreach (var oldComp in Restrictions.CompanyFilter)
					{
						var comp = new Company();
						comp.Code = oldComp.Code;
						comp.Include = oldComp.Include;
						comp.SegmentNumber = oldComp.SegmentNumber;

						result.Restrictions.CompanyFilter.Add(comp);
					}
				}
			}

			if (EndUserData != null)
			{
				result.EndUserData = new EndUserDataDataItem();
				result.EndUserData.EndUserBrowserAgent = EndUserData.EndUserBrowserAgent;
				result.EndUserData.EndUserIP = EndUserData.EndUserIP;
				result.EndUserData.RequestOrigin = EndUserData.RequestOrigin;
			}

			return result;
		}
	}
}
