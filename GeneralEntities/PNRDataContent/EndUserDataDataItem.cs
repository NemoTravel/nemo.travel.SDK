using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Данные о конечном пользователе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class EndUserDataDataItem
	{
		/// <summary>
		/// IP адрес
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string EndUserIP { get; set; }

		/// <summary>
		/// Тип ПО-клиента пользователя
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string EndUserBrowserAgent { get; set; }

		/// <summary>
		/// Данные об исходном сайте, где пользователь начал поиск
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string RequestOrigin { get; set; }

		public EndUserDataDataItem Copy()
		{
			var result = new EndUserDataDataItem();

			result.EndUserIP = EndUserIP;
			result.EndUserBrowserAgent = EndUserBrowserAgent;
			result.RequestOrigin = RequestOrigin;

			return result;
		}
	}
}