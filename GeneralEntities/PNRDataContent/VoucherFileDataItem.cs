using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Obsolete("Вообще-то для \"бумажных\" документов в файликах изначально был сделан PaperDocumentDataItem")]
	public class VoucherFileDataItem
	{
		/// <summary>
		/// Тип файла
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Type { get; set; }

		/// <summary>
		/// Контент файла
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Content { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as VoucherFileDataItem;
			if (other == null)
			{
				return false;
			}

			return Type == other.Type && Content == other.Content;
		}

		public VoucherFileDataItem Copy()
		{
			var result = new VoucherFileDataItem();

			result.Type = Type;
			result.Content = Content;

			return result;
		}
	}
}