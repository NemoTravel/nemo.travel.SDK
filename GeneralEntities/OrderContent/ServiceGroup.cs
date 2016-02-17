using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	/// <summary>
	/// Содержит описание группы услуг
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ServiceGroup
	{
		/// <summary>
		/// Ссылка на услуги в рамках данной группы
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public RefList<int> ServiceRef { get; set; }

		/// <summary>
		/// Тип группы услуг
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public ServiceGroupType GroupType { get; set; }

		/// <summary>
		/// ИД брони
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public long? BookID { get; set; }
	}
}