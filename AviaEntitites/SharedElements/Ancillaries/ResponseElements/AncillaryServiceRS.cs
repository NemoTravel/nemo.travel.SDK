using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.ResponseElements
{
	/// <summary>
	/// Данные допуслуги в ответе поиска
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServiceRS : BaseAncillaryService
	{
		/// <summary>
		/// ИАТА код а/к, предоставляющей данную допуслугу
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string CompanyCode { get; set; }

		/// <summary>
		/// Признак возможности возврата
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public RefundableEnum Refundability { get; set; }

		/// <summary>
		/// Признак необходимости указания описания допуслуги при бронировании
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool SSRDescriptionRequired { get; set; }

		/// <summary>
		/// Тип ЭМД необходимый для выписки данной допуслуги
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = true)]
		public EMDType EmdType { get; set; }


		public AncillaryServiceRS DeepCopy()
		{
			var result = new AncillaryServiceRS();

			CopyTo(result);

			return result;
		}

		protected void CopyTo(AncillaryServiceRS target)
		{
			base.CopyTo(target);

			target.CompanyCode = CompanyCode;
			target.Refundability = Refundability;
			target.SSRDescriptionRequired = SSRDescriptionRequired;
			target.EmdType = EmdType;
		}
	}
}