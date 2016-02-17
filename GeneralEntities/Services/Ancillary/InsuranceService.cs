using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Описание допуслуги страхования
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class InsuranceService : BaseService
	{
		/// <summary>
		/// Поставщик услуги
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public InsuranceVendor Vendor { get; set; }

		/// <summary>
		/// Тип страховки
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string InsuranceLevel { get; set; }

		/// <summary>
		/// УРЛ к документу/билету
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string DocumentURL { get; set; }
	}
}