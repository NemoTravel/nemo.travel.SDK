using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Содержит информацию о сборе при оплате определённой картой в ГДС
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CCTypeFee
	{
		/// <summary>
		/// Тип карты, для которой применяется данный сбор
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public TypeList<string> CCTypes { get; set; }

		/// <summary>
		/// Сбор при оплате данными типами карт в а/к
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public Money Fee { get; set; }


		public CCTypeFee()
		{
			CCTypes = new TypeList<string>();
		}


		public CCTypeFee Copy()
		{
			var result = new CCTypeFee();

			if (CCTypes != null)
			{
				result.CCTypes = new TypeList<string>(CCTypes);
			}

			if (Fee != null)
			{
				result.Fee = Fee.Copy();
			}

			return result;
		}
	}
}