using System;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightsProcessingData
	{
		/// <summary>
		/// Количество перелётов от поставщиков
		/// </summary>
		[DataMember(Order = 0)]
		public int FlightsFromSuppliersCount { get; set; }

		/// <summary>
		/// Количество перелётов от поставщиков по источникам
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public FlightsBySourcesCount FlightsFromSuppliersSources { get; set; }

		/// <summary>
		/// Количество размноженных перелётов
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? PropogatedFlightsCount { get; set; }

		/// <summary>
		/// Количество размноженных перелётов по источникам
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public FlightsBySourcesCount PropogatedFlightsSources { get; set; }

		/// <summary>
		/// Количество правил ЦО
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public int? PricingRulesCount { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false, Name = "PricingDuration")]
		public string PricingDurationString
		{
			get
			{
				if (PricingDuration != null)
				{
					return PricingDuration.ToString();
				}
				return null;
			}

			set
			{
				if (value != null)
				{
					PricingDuration = TimeSpan.Parse(value);
				}
			}
		}

		/// <summary>
		/// Длительность выполнения ЦО
		/// </summary>
		[IgnoreDataMember]
		public TimeSpan? PricingDuration { get; set; }

		/// <summary>
		/// Количество отфильтрованных перелётов
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public int? AfterFilterFlightsCount { get; set; }

		/// <summary>
		/// Количество отфильтрованных перелётов по источникам
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public FlightsBySourcesCount AfterFilterFlightsSources { get; set; }

		/// <summary>
		/// Количество замикшированных перелётов
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public int? MixedFlightsCount { get; set; }

		/// <summary>
		/// Количество замикшированных перелётов по источникам
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public FlightsBySourcesCount MixedFlightsSources { get; set; }

		/// <summary>
		/// Список применившихся правил маршрутизации
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public RouterRulesList AppliedRouterRules { get; set; }

		/// <summary>
		/// Список блокирующих фильтров
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public TriggeredRequestFiltersList TriggeredRequestFilters { get; set; }
	}
}