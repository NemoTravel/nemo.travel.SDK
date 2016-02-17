using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Содержит описание произвольной услуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ArbitraryService : BaseService
	{
		/// <summary>
		/// ИД предопределённой услуги, в случае если это она
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public int? PreDefinedServiceID { get; set; }

		/// <summary>
		/// Название услуги
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Краткое описание услуги
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string ShortDescription { get; set; }

		/// <summary>
		/// Текстовое описание услуги
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string Description { get; set; }
	}
}