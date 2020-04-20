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
		[DataMember(Order = 0)]
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

		public override bool Equals(object obj)
		{
			var other = obj as LoyaltyCardDataItem;
			if (other == null)
			{
				return false;
			}

			return OwnerType == other.OwnerType && Owner == other.Owner && Number == other.Number &&
				Status == other.Status && StatusCode == other.StatusCode;
		}

		public LoyaltyCardDataItem Copy()
		{
			var result = new LoyaltyCardDataItem();

			result.OwnerType = OwnerType;
			result.Owner = Owner;
			result.Number = Number;
			result.Status = Status;
			result.StatusCode = StatusCode;

			return result;
		}
	}
}