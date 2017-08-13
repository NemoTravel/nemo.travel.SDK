using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	/// <summary>
	/// Базовый класса для ФОПов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[KnownType(typeof(CreditCardFOP))]
	[KnownType(typeof(NumberedFOP))]
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
	}
}