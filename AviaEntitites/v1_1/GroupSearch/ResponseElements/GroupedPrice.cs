using AviaEntities.v1_1.FlightSearch.ResponseElements;
using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию о сгруппированных ценах
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "GroupedPrice_1_1")]
	public class GroupedPrice : Price
	{
		/// <summary>
		/// ИД пакета реквизитов, из которого была полученая данная цена
		/// </summary>
		[DataMember(IsRequired = true, Order = 4)]
		public int SourceID { get; set; }

		/// <summary>
		/// Информация о классах перелёта, к которым применяется данная цена
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public BookingClassList BookingClassInfo { get; set; }

		/// <summary>
		/// Вычисление полной цены перелёта по всем пассажирам
		/// </summary>
		[IgnoreDataMember]
		public Money TotalPrice
		{
			get
			{
				if (PassengerFares != null && PassengerFares.Count > 0)
				{
					var result = PassengerFares[0].TotalFare * PassengerFares[0].Quantity;
					for (int i = 1; i < PassengerFares.Count; i++)
					{
						result += (PassengerFares[i].TotalFare * PassengerFares[i].Quantity);
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