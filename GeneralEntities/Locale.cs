using System.Globalization;

namespace GeneralEntities
{
	public class Locale
	{
		public static CultureInfo RUCulture { get; set; }

		public static CultureInfo UsCulture { get; set; }

		static Locale()
		{
			RUCulture = new CultureInfo("ru-RU");
			UsCulture = new CultureInfo("en-US");
		}
	}
}
