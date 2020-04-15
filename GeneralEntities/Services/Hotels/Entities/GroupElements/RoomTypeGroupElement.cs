namespace GeneralEntities.BookContent.Entities.GroupElements
{
	public class RoomTypeGroupElement
	{
		public int Id;

		public string SupplierId;

		public string Name;

		public string CommonName;

		public RoomTypeGroupElement Copy()
		{
			return new RoomTypeGroupElement()
			{
				Id = Id,
				SupplierId = SupplierId,
				Name = Name,
				CommonName = CommonName
			};
		}
	}
}