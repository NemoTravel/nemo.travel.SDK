namespace GeneralEntities.BookContent.Entities.Booking
{
	public class Person
	{
		public string LastName { get; set; }

		public string FirstName { get; set; }

		public string Email { get; set; }

		public string Nationality { get; set; }

		public string Phone { get; set; }

		/// <summary>
		/// Составляет полное имя из имени и фамилии (если имеются, иначе - пустая строка)
		/// </summary>
		/// <returns></returns>
		public string GetFullName()
		{
			string result;

			if (!string.IsNullOrWhiteSpace(LastName))
			{
				result = LastName;
				if (!string.IsNullOrWhiteSpace(FirstName))
				{
					result += " " + FirstName;
				}
			}
			else
			{
				result = !string.IsNullOrWhiteSpace(FirstName) ? FirstName : "";
			}

			return result;
		}
	}
}