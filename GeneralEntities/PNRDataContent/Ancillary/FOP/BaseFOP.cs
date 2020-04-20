using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	/// <summary>
	/// Базовый класса для ФОПов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[KnownType(typeof(InvoiceFOP))]
	[KnownType(typeof(CreditCardFOP))]
	[KnownType(typeof(TokenizedCardFOP))]
	[KnownType(typeof(PrepaymentFOP))]
	public class BaseFOP
	{
		/// <summary>
		/// Сумма по данному ФОПу
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public Money Amount { get; set; }

		/// <summary>
		/// Тип ФОПа
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public FOPType Type { get; set; }

		public override bool Equals(object other)
		{
			var otherFOP = other as BaseFOP;
			if (otherFOP != null)
			{
				return Amount == otherFOP.Amount && Type == otherFOP.Type;
			}

			return false;
		}

		public virtual BaseFOP Copy()
		{
			var result = new BaseFOP();
			CopyTo(result);
			return result;
		}

		protected void CopyTo<T>(T fop) where T : BaseFOP
		{
			fop.Type = Type;
			fop.Amount = Amount?.Copy();
		}

		public override int GetHashCode()
		{
			var hash = Type.GetHashCode();
			hash ^= Amount == null ? 0 : Amount.GetHashCode();

			return hash;
		}
	}
}