using GeneralEntities.ExtendedDateTime;
using SharedAssembly;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание информации о визе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class VisaDataItem
	{
		/// <summary>
		/// Номер визы
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Место рождения пассажира
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string BirthPlace { get; set; }

		/// <summary>
		/// Место выдачи визы
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string IssuePlace { get; set; }

		/// <summary>
		/// Дата выдачи визы
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public DateTimeEx IssueDate { get; set; }

		/// <summary>
		/// Страна, к которой применяется виза
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string ApplicableCountry { get; set; }

		public VisaDataItem()
		{ }

		/// <summary>
		/// Создание объекта класса с заполнением данных на основании SSR DOCO строки
		/// </summary>
		/// <param name="docoString">SSR DOCO строка</param>
		/// <param name="supplier">Поставщик, из которого была получена SSR DOCS строка</param>
		public VisaDataItem(string docoString, AviaSuppliers? supplier = null)
		{
			var tmp = docoString.Split('/');
			int i = 0;
			//ибо только Сэйбр на данный момент добавляет в SSR строку статус SSRки
			if (supplier.HasValue && supplier.Value == AviaSuppliers.Sabre)
			{
				i = 1;
			}

			BirthPlace = tmp[i];
			Number = tmp[i + 2];
			IssuePlace = tmp[i + 3];
			IssueDate = new DateTimeEx(tmp[i + 4], Formats.DATE_FORMAT);
			ApplicableCountry = tmp[i + 5];
		}
	}
}