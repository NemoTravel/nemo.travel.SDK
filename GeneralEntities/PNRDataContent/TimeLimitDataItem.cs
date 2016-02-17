using GeneralEntities.ExtendedDateTime;
using SharedAssembly;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание для различных ТЛов брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TimeLimitDataItem
	{
		protected DateTimeEx priceTimeLimit;
		protected DateTimeEx segmentsTimeLimit;
		protected DateTimeEx ticketingTimeLimit;
		protected DateTimeEx agencyTimeLimit;
		protected DateTimeEx voidTimeLimit;

		/// <summary>
		/// Эффективный ТЛ брони
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public DateTimeEx EffectiveTimeLimit
		{
			get
			{
				DateTimeEx tl = null;

				if (PriceTimeLimit != null && (tl == null || PriceTimeLimit.DateTime < tl))
				{
					tl = PriceTimeLimit;
				}

				if (SegmentsTimeLimit != null && (tl == null || SegmentsTimeLimit.DateTime < tl))
				{
					tl = SegmentsTimeLimit;
				}

				if (TicketingTimeLimit != null && (tl == null || TicketingTimeLimit.DateTime < tl))
				{
					tl = TicketingTimeLimit;
				}

				if (AgencyTimeLimit != null && (tl == null || AgencyTimeLimit.DateTime < tl))
				{
					tl = AgencyTimeLimit;
				}

				return tl;
			}

			set { }
		}

		/// <summary>
		/// ТЛ цены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public DateTimeEx PriceTimeLimit
		{
			get { return priceTimeLimit; }
			set
			{
				if (value != null)
				{
					value.OutFormat = Formats.FULL_DATE_TIME_FORMAT;
				}
				priceTimeLimit = value;
			}
		}

		/// <summary>
		/// ТЛ на сегменты
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public DateTimeEx SegmentsTimeLimit
		{
			get { return segmentsTimeLimit; }
			set
			{
				if (value != null)
				{
					value.OutFormat = Formats.FULL_DATE_TIME_FORMAT;
				}
				segmentsTimeLimit = value;
			}
		}

		/// <summary>
		/// ТЛ на выписку
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx TicketingTimeLimit
		{
			get { return ticketingTimeLimit; }
			set
			{
				if (value != null)
				{
					value.OutFormat = Formats.FULL_DATE_TIME_FORMAT;
				}
				ticketingTimeLimit = value;
			}
		}

		/// <summary>
		/// Агентский ТЛ
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx AgencyTimeLimit
		{
			get { return agencyTimeLimit; }
			set
			{
				if (value != null)
				{
					value.OutFormat = Formats.FULL_DATE_TIME_FORMAT;
				}
				agencyTimeLimit = value;
			}
		}

		/// <summary>
		/// ТЛ на войдирование выписки от ГДС
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public DateTimeEx VoidTimeLimit
		{
			get { return voidTimeLimit; }
			set
			{
				if (value != null)
				{
					value.OutFormat = Formats.FULL_DATE_TIME_FORMAT;
				}
				voidTimeLimit = value;
			}
		}
	}
}