using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.LinkedBookInfo
{
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class BookData
	{
		[DataMember(Order = 0)]
		public long ID { get; set; }

		[DataMember(Order = 1)]
		public List<IDLink<int>> ServicesLinks { get; set; }

		[DataMember(Order = 2)]
		public List<IDLink<long>> DataItemsLinks { get; set; }

		public BookData()
		{
			ServicesLinks = new List<IDLink<int>>();
			DataItemsLinks = new List<IDLink<long>>();
		}

		public override bool Equals(object obj)
		{
			var other = obj as BookData;
			if (other == null)
			{
				return false;
			}

			if (other.ID != ID)
			{
				return false;
			}

			if (!(other.ServicesLinks == null && ServicesLinks == null ||
				other.ServicesLinks != null && ServicesLinks != null && other.ServicesLinks.Count == ServicesLinks.Count && other.ServicesLinks.TrueForAll(link => ServicesLinks.Contains(link))))
			{
				return false;
			}

			return other.DataItemsLinks == null && DataItemsLinks == null ||
				other.DataItemsLinks != null && DataItemsLinks != null && other.DataItemsLinks.Count == DataItemsLinks.Count && other.DataItemsLinks.TrueForAll(link => DataItemsLinks.Contains(link));
		}

		public BookData Copy()
		{
			var result = new BookData();

			result.ID = ID;
			result.ServicesLinks.AddRange(ServicesLinks.Select(link => link.Copy()));
			result.DataItemsLinks.AddRange(DataItemsLinks.Select(link => link.Copy()));

			return result;
		}
	}
}