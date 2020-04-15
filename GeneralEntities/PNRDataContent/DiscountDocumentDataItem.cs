using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание документа, который является основанием для скидки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class DiscountDocumentDataItem
	{
		protected DateTimeEx elapsedTime;

		/// <summary>
		/// Тип документа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public DiscountDocumentType Type { get; set; }

		/// <summary>
		/// Номер документа
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Дата и время истечения срока действия документа в формате dd.mm.yyyy (например 31.12.2012)
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx ElapsedTime
		{
			get { return elapsedTime; }
			set
			{
				elapsedTime = value;
				if (elapsedTime != null)
				{
					elapsedTime.OutFormat = Formats.DATE_FORMAT;
				}
			}
		}

		public override bool Equals(object obj)
		{
			var other = obj as DiscountDocumentDataItem;
			if (other == null)
			{
				return false;
			}

			return Type == other.Type && Number == other.Number && Equals(ElapsedTime, other.ElapsedTime);
		}

		public DiscountDocumentDataItem Copy()
		{
			var result = new DiscountDocumentDataItem();

			result.Type = Type;
			result.Number = Number;
			result.ElapsedTime = ElapsedTime?.Copy();

			return result;
		}
	}
}