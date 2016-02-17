using AviaEntities.SharedElements;
using AviaEntities.Ticketing.RequestElements;
using GeneralEntities;
using GeneralEntities.Market;
using GeneralEntities.PNRDataContent;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.Ticketing
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "TicketingRQBody_1_1")]
	public class TicketingRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Валидирующей перевозчик, под которым будет проводится выписка
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string ValCompany { get; set; }

		/// <summary>
		/// Комиссия для передачи в ГДС
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public AviaEntities.v1_1.Ticketing.RequestElements.FinancialInfo FinancialInformation { get; set; }

		/// <summary>
		/// Эндорсменты
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public EndorsementList Endorsements { get; set; }

		/// <summary>
		/// Тур код для данной брони
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string TourCode { get; set; }

		/// <summary>
		/// Тикет десигнатор для данной брони
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string TicketDesignator { get; set; }

		/// <summary>
		/// Некие данные, которые требуется добавить в ПНР перед выпиской
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public PNRDataItemList DataItems { get; set; }

		/// <summary>
		/// Тестово-отладочные параметры
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public TestMode TestMode { get; set; }

		/// <summary>
		/// Получение комиссии а/к для определённого типа пассажира
		/// </summary>
		/// <param name="passType">Тип пассажира, для которого требуется получить комиссию а/к</param>
		/// <returns>Комиссия а/к для указанного типа. null если не задана.</returns>
		public ServiceCommission GetAirlineCommission(PassTypes passType)
		{
			ServiceCommission result = null;

			if (FinancialInformation != null)
			{
				if (FinancialInformation.CustomComission != null && FinancialInformation.CustomComission.ContainsKey(passType))
				{
					result = FinancialInformation.CustomComission[passType].AirlineComission;
				}
				else if (FinancialInformation.Comission != null)
				{
					result = FinancialInformation.Comission.AirlineComission;
				}
			}

			return result;
		}
	}
}