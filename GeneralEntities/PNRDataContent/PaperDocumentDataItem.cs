using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит информацию о некоем бумажном документе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PaperDocumentDataItem
	{
		/// <summary>
		/// Тип бумажного документа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PDType Type { get; set; }

		/// <summary>
		/// Формат документа
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Format { get; set; }

		/// <summary>
		/// Кодировка документа
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string Encoding { get; set; }

		/// <summary>
		/// Собственно данные документа
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string DocumentData { get; set; }

		/// <summary>
		/// Признак обёртки данных документа в Base64
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool IsBase64Wrapped { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as PaperDocumentDataItem;
			if (other == null)
			{
				return false;
			}

			return Type == other.Type && Format == other.Format && Encoding == other.Encoding &&
					DocumentData == other.DocumentData && IsBase64Wrapped == other.IsBase64Wrapped;
		}

		public PaperDocumentDataItem Copy()
		{
			var result = new PaperDocumentDataItem();

			result.Type = Type;
			result.Format = Format;
			result.Encoding = Encoding;
			result.DocumentData = DocumentData;
			result.IsBase64Wrapped = IsBase64Wrapped;

			return result;
		}
	}
}