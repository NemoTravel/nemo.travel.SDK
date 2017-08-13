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