using GeneralEntities.ExtendedDateTime;
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
		protected DateTimeEx ticketingTimeLimit;
		protected DateTimeEx agencyTimeLimit;
		protected DateTimeEx voidTimeLimit;
		protected DateTimeEx advancedPurchaseTimeLimit;
		protected DateTimeEx effectiveTimeLimit;
		protected DateTimeEx consolidatorTimeLimit;

		/// <summary>
		/// Эффективный ТЛ брони
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public DateTimeEx EffectiveTimeLimit
		{
			get { return effectiveTimeLimit; }

			set { effectiveTimeLimit = SetOutFormat(value); }
		}

		/// <summary>
		/// ТЛ цены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public DateTimeEx PriceTimeLimit
		{
			get { return priceTimeLimit; }
			set { priceTimeLimit = SetOutFormat(value); }
		}

		/// <summary>
		/// ТЛ на выписку
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx TicketingTimeLimit
		{
			get { return ticketingTimeLimit; }
			set { ticketingTimeLimit = SetOutFormat(value); }
		}

		/// <summary>
		/// Агентский ТЛ
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx AgencyTimeLimit
		{
			get { return agencyTimeLimit; }
			set { agencyTimeLimit = SetOutFormat(value); }
		}

		/// <summary>
		/// ТЛ на войдирование выписки от ГДС
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public DateTimeEx VoidTimeLimit
		{
			get { return voidTimeLimit; }
			set { voidTimeLimit = SetOutFormat(value); }
		}

		/// <summary>
		/// ТЛ из секции Advanced Purchase УПТ
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public DateTimeEx AdvancedPurchaseTimeLimit
		{
			get { return advancedPurchaseTimeLimit; }
			set { advancedPurchaseTimeLimit = SetOutFormat(value); }
		}

		/// <summary>
		/// ТЛ консолидатора
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public DateTimeEx ConsolidatorTimeLimit
		{
			get { return consolidatorTimeLimit; }
			set { consolidatorTimeLimit = SetOutFormat(value); }
		}

		public TimeLimitDataItem Copy()
		{
			var result = new TimeLimitDataItem();

			result.EffectiveTimeLimit = EffectiveTimeLimit?.Copy();
			result.PriceTimeLimit = PriceTimeLimit?.Copy();
			result.TicketingTimeLimit = TicketingTimeLimit?.Copy();
			result.AgencyTimeLimit = AgencyTimeLimit?.Copy();
			result.VoidTimeLimit = VoidTimeLimit?.Copy();
			result.AdvancedPurchaseTimeLimit = AdvancedPurchaseTimeLimit?.Copy();
			result.ConsolidatorTimeLimit = ConsolidatorTimeLimit?.Copy();

			return result;
		}

		public override bool Equals(object obj)
		{
			var other = obj as TimeLimitDataItem;
			if (other == null)
			{
				return false;
			}

			return PriceTimeLimit == other.PriceTimeLimit && TicketingTimeLimit == other.TicketingTimeLimit && AgencyTimeLimit == other.AgencyTimeLimit &&
				VoidTimeLimit == other.VoidTimeLimit && AdvancedPurchaseTimeLimit == other.AdvancedPurchaseTimeLimit && EffectiveTimeLimit == other.EffectiveTimeLimit &&
				ConsolidatorTimeLimit == other.ConsolidatorTimeLimit;
		}

		private DateTimeEx SetOutFormat(DateTimeEx value)
		{
			if (value != null)
			{
				value.OutFormat = Formats.FULL_DATE_TIME_FORMAT;
			}

			return value;
		}
	}
}