using GeneralEntities.Market;
using System.Globalization;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Содержит информацию о таксе цены
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Tax : Money
	{
		/// <summary>
		/// Код таксы
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string TaxCode { get; set; }

		/// <summary>
		/// Тип таксы, специфика Амадеуса
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Type { get; set; }

		[IgnoreDataMember]
		public double? AgencyAmount { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false, Name = "AgencyAmount")]
		public string AgencyAmountString
		{
			get
			{
				return AgencyAmount.HasValue ? AgencyAmount.Value.ToString(CultureInfo.InvariantCulture) : null;
			}
			set
			{
				if (value != null)
				{
					AgencyAmount = double.Parse(value, CultureInfo.InvariantCulture);
				}
			}
		}

		/// <summary>
		/// Природа таксы, специфика Амадеуса
		/// </summary>
		public string Nature { get; set; }


		public Tax()
		{
		}

		public Tax(Tax other)
			: base(other)
		{
			TaxCode = other.TaxCode;
			Type = other.Type;
			AgencyAmount = other.AgencyAmount;
			AgencyAmountString = other.AgencyAmountString;
			Nature = other.Nature;
		}

		public Tax(string taxCode, double amount, string currency, ICurrencyConverter currencyConverter = null) : base(amount, currency, currencyConverter)
		{
			TaxCode = taxCode;
		}


		public new Tax Copy()
		{
			return new Tax(this);
		}
	}
}