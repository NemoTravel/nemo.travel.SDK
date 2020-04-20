using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание данных для скидки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class DiscountDataItem : CommissionDataItem
	{
		/// <summary>
		/// Код авторизации скидки
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public string AuthCode { get; set; }


		public DiscountDataItem()
		{
		}

		public DiscountDataItem(DiscountDataItem other)
			: base(other)
		{
			AuthCode = other.AuthCode;
		}


		public override bool Equals(object obj)
		{
			var other = obj as DiscountDataItem;
			if (other == null)
			{
				return false;
			}

			return AuthCode == other.AuthCode && CommissionDataItem.Equals(this, other);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();

			if (!string.IsNullOrEmpty(AuthCode))
			{
				result ^= AuthCode.GetHashCode();
			}

			return result;
		}

		public new DiscountDataItem Copy()
		{
			return new DiscountDataItem(this);
		}
	}
}