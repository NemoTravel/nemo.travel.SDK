using SharedAssembly;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Traveller
{
	/// <summary>
	/// Информация о визе пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class VisaInformation
	{
		/// <summary>
		/// Номер визы
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string Number { get; set; }

		/// <summary>
		/// Страна выдачи
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string IssueCountry { get; set; }

		/// <summary>
		/// Место выдачи
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public string IssuePlace { get; set; }

		/// <summary>
		/// Страна рождения пассажира
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public string BirthCountry { get; set; }

		/// <summary>
		/// Место рождения
		/// </summary>
		[DataMember(IsRequired = true, Order = 4)]
		public string BirthCity { get; set; }

		/// <summary>
		/// Дата выдачи визы
		/// </summary>
		[DataMember(IsRequired = true, Order = 5)]
		public string IssueDate { get; set; }

		public VisaInformation()
		{ }

		/// <summary>
		/// Создание объекта класса с заполнением данных на основании SSR DOCO строки
		/// </summary>
		/// <param name="docoString">SSR DOCO строка</param>
		/// <param name="supplier">Поставщик, из которого была получена SSR DOCS строка</param>
		public VisaInformation(string docoString, AviaSuppliers? supplier = null)
		{
			var tmp = docoString.Split('/');
			int i = 0;
			//ибо только Сэйбр на данный момент добавляет в SSR строку статус SSRки
			if (supplier.HasValue && supplier.Value == AviaSuppliers.Sabre)
			{
				i = 1;
			}

			var birthPlace = tmp[i].Split(' ');
			if (birthPlace.Length > 1)
			{
				if (birthPlace[0].Length == 2)
				{
					BirthCountry = birthPlace[0];
					BirthCity = tmp[i].Replace(BirthCountry + " ", "");
				}
				else
				{
					BirthCountry = birthPlace[1];
					BirthCity = tmp[i].Replace(" " + BirthCountry, "");
					
				}
			}
			else
			{
				if (tmp[i].Length == 2)
				{
					BirthCountry = tmp[i];
					BirthCity = "";
				}
				else
				{
					BirthCity = tmp[i];
					BirthCountry = "";
				}
			}

			Number = tmp[i + 2];
			IssuePlace = tmp[i + 3];
			DateTime issueDate;
			if (DateTime.TryParseExact(tmp[i + 4], Formats.EDIFACT_DATE_FORMAT, Locale.UsCulture, System.Globalization.DateTimeStyles.None, out issueDate))
			{
				IssueDate = issueDate.ToString(Formats.DATE_FORMAT);
			}
			else if (DateTime.TryParseExact(tmp[i + 4], Formats.SHORT_EDIFACT_DATE_FORMAT, Locale.UsCulture, System.Globalization.DateTimeStyles.None, out issueDate))
			{
				IssueDate = issueDate.ToString(Formats.DATE_FORMAT);
			}
			IssueCountry = tmp[i + 5];
		}
	}
}