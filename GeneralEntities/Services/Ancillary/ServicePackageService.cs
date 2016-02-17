using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Услуга - сервисный пакет
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ServicePackageService : BaseService
	{
		/// <summary>
		/// Просто какие-то не структурированные данные об услугах в пакете
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string RawData { get; set; }
	}
}