using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	/// <summary>
	/// Содержит информацию об определённой допуслуге
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServiceRS : BaseAncillaryService
	{
		/// <summary>
		/// ИАТА код а/к, предоставляющей данную допуслугу
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string CompanyCode { get; set; }
	}
}