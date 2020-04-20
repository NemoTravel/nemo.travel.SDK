using GeneralEntities.Market;
using System.Globalization;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию о таксе цены
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Tax_1_1")]
	public class Tax : Money
	{
		/// <summary>
		/// Код таксы
		/// </summary>
		[DataMember(Order = 2, IsRequired = true, EmitDefaultValue = false)]
		public string TaxCode { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string Type { get; set; }

		[IgnoreDataMember]
		public double? AgencyAmount { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false, Name = "AgencyAmount")]
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
	}
}