using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.LinkedBookInfo
{
	[CollectionDataContract(Namespace = "http://nemo.travel/STL", ItemName = "Book")]
	public class BooksDataCollection : List<BookData> { }
}