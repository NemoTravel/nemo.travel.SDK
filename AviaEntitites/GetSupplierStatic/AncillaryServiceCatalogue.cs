using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic
{
	/// <summary>
	/// Содержит данные для получения справочника допуслуг
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServiceCatalogue
	{
		/// <summary>
		/// Код а/к для которой нужно получить справочник допуслуг
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Airline { get; set; }
	}
}