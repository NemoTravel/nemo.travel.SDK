using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию, специфичную для отдельного перелёта в сгруппированной выдаче
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightPriceGroup_1_1")]
	public class FlightPriceGroup
	{
		/// <summary>
		/// Информация о сегментах, специфичная для данного перелёта
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public FlightSegmentBindingList OrderedFlightSegments { get; set; }

		/// <summary>
		/// Номера цен, к которым относится данный перелёт
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public FlightPriceInfoList Flights { get; set; }

		/// <summary>
		/// Суммарное время ожидания между сегментами перелёта.
		/// Не учитывается время между сегментами из запроса.
		/// </summary>
		[DataMember(Order = 6, Name = "SegmentSummaryConnectionTimeout", EmitDefaultValue = false)]
		public string SerializableSegmentSummaryConnectionTimeout
		{
			get
			{
				if (SegmentSummaryConnectionTimeout.HasValue)
				{
					return SegmentSummaryConnectionTimeout.ToString();
				}
				else
				{
					return null;
				}
			}
			set
			{
				SegmentSummaryConnectionTimeout = TimeSpan.Parse(value);
			}
		}

		/// <summary>
		/// Суммарное время ожидания между сегментами перелёта.
		/// Не учитывается время между сегментами из запроса.
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		public TimeSpan? SegmentSummaryConnectionTimeout { get; set; }

		/// <summary>
		/// Создание нового объекта класса с дефолтной инициализацией необходимых параметров
		/// </summary>
		public FlightPriceGroup()
		{
			SegmentSummaryConnectionTimeout = new TimeSpan(0, 0, 0);
			OrderedFlightSegments = new FlightSegmentBindingList();
			Flights = new FlightPriceInfoList();
		}
	}
}