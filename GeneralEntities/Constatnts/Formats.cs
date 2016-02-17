namespace GeneralEntities
{
	/// <summary>
	/// Форматы преобразования даты-времени к строке
	/// </summary>
	public class Formats
	{
		/// <summary>
		/// Форматы даты - "dd.MM.yyyy"
		/// </summary>
		public const string DATE_FORMAT = "dd.MM.yyyy";

		/// <summary>
		/// Формат даты-времени - "yyyy-MM-ddTHH:mm:ss"
		/// </summary>
		public const string DATE_TIME_FORMAT = "yyyy-MM-ddTHH:mm:ss";

		/// <summary>
		/// Форматы даты - "yyyy-MM-dd"
		/// </summary>
		public const string DATE_WITH_DASHES_FORMAT = "yyyy-MM-dd";

		/// <summary>
		/// Полный формат даты-времени (включая часовой пояс)
		/// </summary>
		public const string FULL_DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss zzz";

		/// <summary>
		/// Формат даты-времени с точностью до миллисекунды
		/// </summary>
		public const string EXACT_DATE_TIME_FORMAT = "yyyy-MM-ddTHH:mm:ss.fff";

		/// <summary>
		/// Формат даты-времени - "yyyy-MM-dd HH:mm:ss"
		/// </summary>
		public const string RAIL_DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

		/// <summary>
		/// Формат даты для паспортных строк EDIFACT - "ddMMMyyyy"
		/// </summary>
		public const string EDIFACT_DATE_FORMAT = "ddMMMyyyy";

		/// <summary>
		/// Формат даты для паспортных строк EDIFACT - "ddMMMyy"
		/// </summary>
		public const string SHORT_EDIFACT_DATE_FORMAT = "ddMMMyy";

		/// <summary>
		/// Формат цены - "F"
		/// </summary>
		public const string PRICE_FORMAT = "F";
	}
}