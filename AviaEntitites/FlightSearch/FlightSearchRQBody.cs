using AviaEntities.FlightSearch.RequestElements;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch
{
	/// <summary>
	/// Тело запроса поиска перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightSearchRQBody
	{
		/// <summary>
		/// Содержит техническую информацию о сегметах запрашиваемого перелёта
		/// (время вылета, прямой или с пересадками и т.д.)
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public FlightDirection RequestedFlightInfo { get; set; }

		/// <summary>
		/// Информация о пассажирах, для которых выполняется поиск перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public List<Passenger> Passengers { get; set; }

		/// <summary>
		/// Допольнительный условия/ограничея, накладываемые на поиск перелётов
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public AdditionalSearchInfo Restrictions { get; set; }

		/// <summary>
		/// Привязка к сегменту из запроса
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public int? MultiOWRequestedSegmentNumber { get; set; }

		/// <summary>
		/// Выполняет полное копирование объекта, реализация интерфейса ICloneable
		/// </summary>
		/// <returns>Результат копирования</returns>
		public FlightSearchRQBody Copy()
		{
			var result = new FlightSearchRQBody();

			result.MultiOWRequestedSegmentNumber = MultiOWRequestedSegmentNumber;

			result.RequestedFlightInfo = new FlightDirection();
			result.RequestedFlightInfo.ODPairs = new FlightPairList();
			result.Passengers = new List<Passenger>();

			result.RequestedFlightInfo.AroundDates = RequestedFlightInfo.AroundDates;
			result.RequestedFlightInfo.Direct = RequestedFlightInfo.Direct;
			result.RequestedFlightInfo.SubType = RequestedFlightInfo.SubType;

			foreach (var seg in RequestedFlightInfo.ODPairs)
			{
				result.RequestedFlightInfo.ODPairs.Add(seg.Copy());
			}

			foreach (var pass in Passengers)
			{
				var tmpPass = new Passenger();
				tmpPass.Count = pass.Count;
				tmpPass.Type = pass.Type;

				result.Passengers.Add(tmpPass);
			}

			if (Restrictions != null)
			{
				result.Restrictions = new AdditionalSearchInfo();
				result.Restrictions.ClassPref = Restrictions.ClassPref;
				result.Restrictions.CurrencyCode = Restrictions.CurrencyCode;
				result.Restrictions.PrivateFaresOnly = Restrictions.PrivateFaresOnly;
				result.Restrictions.SourcePreference = Restrictions.SourcePreference;

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

			return result;
		}
	}
}