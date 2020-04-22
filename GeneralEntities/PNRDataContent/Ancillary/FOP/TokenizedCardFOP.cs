using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	/// <summary>
	/// ФОП с токеном карты
	/// </summary>
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class TokenizedCardFOP : BaseFOP
	{
		/// <summary>
		/// Номер токена
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Ссылка для перенаправления пользователя на страницу оплаты
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string CallBackUrl { get; set; }


		public override bool Equals(object other)
		{
			var otherFOP = other as TokenizedCardFOP;
			if (otherFOP == null)
			{
				return false;
			}

			return
				Number == otherFOP.Number &&
				CallBackUrl == otherFOP.CallBackUrl &&
				base.Equals(otherFOP);
		}

		public override int GetHashCode()
		{
			var hash = base.GetHashCode();
			hash ^= Number == null ? 0 : Number.GetHashCode();
			hash ^= CallBackUrl == null ? 0 : CallBackUrl.GetHashCode();

			return hash;
		}
	}
}