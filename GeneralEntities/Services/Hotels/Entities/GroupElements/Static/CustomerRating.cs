namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	public class CustomerRating
	{
		public decimal Room { get; set; }

		public decimal Facilities { get; set; }

		public decimal Cleanness { get; set; }

		public decimal Food { get; set; }

		public decimal Staff { get; set; }

		public decimal CheckIn { get; set; }

		public decimal ValueForMoney { get; set; }

		public bool Equals(CustomerRating other) =>
			Room == other.Room &&
			Facilities == other.Facilities &&
			Cleanness == other.Cleanness &&
			Food == other.Food &&
			Staff == other.Staff &&
			CheckIn == other.CheckIn &&
			ValueForMoney == other.ValueForMoney;

	}
}
