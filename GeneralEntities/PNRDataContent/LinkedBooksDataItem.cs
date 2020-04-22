using GeneralEntities.PNRDataContent.Ancillary.LinkedBookInfo;
using GeneralEntities.Shared;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class LinkedBooksDataItem
	{
		[Obsolete("Список ID связанных заказов был заменён на подробную информацию в элементе BooksData.")]
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RefList<long> BooksIDs { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public BooksDataCollection BooksData { get; set; }

		public LinkedBooksDataItem()
		{
			BooksData = new BooksDataCollection();
		}

		public override bool Equals(object obj)
		{
			var other = obj as LinkedBooksDataItem;
			if (other == null)
			{
				return false;
			}

			return BooksData == null && other.BooksData == null ||
					BooksData != null && other.BooksData != null && BooksData.Count == other.BooksData.Count && BooksData.TrueForAll(data => other.BooksData.Contains(data));
		}

		public LinkedBooksDataItem Copy()
		{
			var result = new LinkedBooksDataItem();

			if (BooksData != null)
			{
				result.BooksData = new BooksDataCollection();
				result.BooksData.AddRange(BooksData.Select(data => data.Copy()));
			}

			return result;
		}
	}
}