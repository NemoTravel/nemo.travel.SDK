using GeneralEntities.Market;
using GeneralEntities.PriceContent;
using GeneralEntities.Shared;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит перелёт - один из результатов поиск
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Flight_1_1")]
	public class Flight : ItemIdentification<string>
	{
		/// <summary>
		/// ИД пакета реквизитов, из которого был получен данный перелёт
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public int SourceID { get; set; }

		/// <summary>
		/// Информация о типизации данного перелёта по различным критериям
		/// </summary>
		[DataMember(Order = 2)]
		public FlightTypeInfo TypeInfo { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public bool MandatoryLatinNames { get; set; }

		/// <summary>
		/// Количество билетов, которые будут выписаны на 1 пассажира при оформлении данного перелёта
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public int? ExpectedTicketCount { get; set; }

		/// <summary>
		/// Сегменты перелёта
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public CompleteSegmentList Segments { get; set; }

		/// <summary>
		/// Цены перелёта
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public PriceList PriceInfo { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public CurrencyRateList UsedRates { get; set; }

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public FareFamilyDescriptionList FareFamiliesDescription { get; set; }

		[DataMember(Order = 12, EmitDefaultValue = false)]
		public SubsidyInformationList SubsidiesInformation { get; set; }

		[DataMember(Order = 13, EmitDefaultValue = false)]
		public bool CanHaveSubsidizedTariffs { get; set; }

		[DataMember(Order = 14, EmitDefaultValue = false)]
		public string BookingURL { get; set; }

		/// <summary>
		/// Вычисление полной цены перелёта по всем пассажирам
		/// </summary>
		[IgnoreDataMember]
		public Money TotalPrice
		{
			get
			{
				if (PriceInfo != null && PriceInfo.Count(pi => pi.PassengerFares != null && pi.PassengerFares.Count > 0) > 0)
				{
					Money result = null;
					foreach (var price in PriceInfo)
					{
						if (price.PassengerFares != null && price.PassengerFares.Count > 0)
						{
							foreach (var passFare in price.PassengerFares)
							{
								var farePrice = passFare.TotalFare * passFare.Quantity;
								if (result == null)
								{
									result = farePrice;
								}
								else
								{
									result += farePrice;
								}
							}
						}
					}
					return result;
				}
				else
				{
					return null;
				}
			}
		}
	}
}