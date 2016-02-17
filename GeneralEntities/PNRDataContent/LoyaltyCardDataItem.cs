using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание карточки участника программы лояльности
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class LoyaltyCardDataItem
	{
		/// <summary>
		/// Тип эмитента программы лояльности
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public LoyaltyCardOwnerType OwnerType { get; set; }

		/// <summary>
		/// Код эмитента программы лояльности 
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Owner { get; set; }

		/// <summary>
		/// Номер карточки участника программы лояльности
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Статус питания
		/// </summary>
		[DataMember(Order = 3)]
		public PNRContentStatus Status { get; set; }

		/// <summary>
		/// Код статуса
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string StatusCode { get; set; }
	}
}