using GeneralEntities.PNRDataContent.Ancillary;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ReferencedBooksDataItem
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public BookIDs ParentBook { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public List<BookIDs> ChildBooks { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as ReferencedBooksDataItem;
			if (other == null)
			{
				return false;
			}

			if (!Equals(ParentBook, other.ParentBook))
			{
				return false;
			}

			if (ChildBooks == null && other.ChildBooks != null || ChildBooks != null && other.ChildBooks == null)
			{
				return false;
			}

			return ChildBooks != null && other.ChildBooks != null &&
				ChildBooks.Count == other.ChildBooks.Count && ChildBooks.TrueForAll(bookID => other.ChildBooks.Contains(bookID));
		}

		public ReferencedBooksDataItem Copy()
		{
			var result = new ReferencedBooksDataItem();

			result.ParentBook = ParentBook?.Copy();

			if (ChildBooks != null)
			{
				result.ChildBooks = new List<BookIDs>(ChildBooks.Count);
				ChildBooks.ForEach(bookID => result.ChildBooks.Add(bookID.Copy()));
			}

			return result;
		}
	}
}