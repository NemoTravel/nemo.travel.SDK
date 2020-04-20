using GeneralEntities.ExtendedDateTime;
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание документа, удостоверяющего личность путешественника
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class DocumentInfoDataItem
	{
		private static Regex docsFormatRegex = new Regex(DOCSPattern, RegexOptions.Compiled);
		private static Regex cleanDocNumberRegex = new Regex(@"[^\w|^а-яА-ЯЁё]", RegexOptions.Compiled);

		/// <summary>
		/// Шаблон для SSR DOCS
		/// </summary>
		public const string DOCSPattern = @"[A-Z]{1}/[A-Z]{2,3}/[A-Z0-9]*/[A-Z]{2,3}/[0-9]{2}[A-Z]{3}[0-9]{2,4}/[A-Z]{1,2}/[0-9]{2}[A-Z]{3}[0-9]{2,4}/([A-Z]*/{0,1}){2}[A-Z]{1}";

		protected DateTimeEx elapsedTime;


		/// <summary>
		/// Тип документа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public DocTypes Type { get; set; }

		/// <summary>
		/// Номер документа
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Код страны выдачи
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string IssueCountryCode { get; set; }

		/// <summary>
		/// Дата и время истечения срока действия документа в формате dd.mm.yyyy (например 31.12.2012)
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx ElapsedTime
		{
			get { return elapsedTime; }
			set
			{
				elapsedTime = value;
				if (elapsedTime != null)
				{
					elapsedTime.OutFormat = Formats.DATE_FORMAT;
				}
			}
		}

		/// <summary>
		/// Документ в ПНРе внесён как SSR DOCS
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool AddedAsDOCS { get; set; }

		/// <summary>
		/// Документ в ПНРе внесён как SSR FOID
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool AddedAsFOID { get; set; }

		public DocumentInfoDataItem()
		{ }

		/// <summary>
		/// Попытка заполнения объекта данными из SSR DOCS строки
		/// </summary>
		/// <param name="docsString">SSR DOCS строка</param>
		/// <param name="supplier">Поставщик, из которого была получена SSR DOCS строка</param>
		public static bool TryCreateDocumentInfoDataItem(string docsString, AviaSuppliers supplier, out DocumentInfoDataItem document)
		{
			document = null;

			if (!docsFormatRegex.IsMatch(docsString))
			{
				return false;
			}

			//ибо только Сэйбр на данный момент добавляет в SSR строку статус SSRки
			var index = supplier == AviaSuppliers.Sabre ? 1 : 0;
			var docsParts = docsString.Split('/');

			document = new DocumentInfoDataItem();

			document.Type = (DocTypes)Enum.Parse(typeof(DocTypes), docsParts[index]);
			document.IssueCountryCode = docsParts[index + 1];
			document.Number = docsParts[index + 2];

			var elapsedTime = DateTime.Parse(docsParts[index + 6], Locale.UsCulture);
			if (elapsedTime < DateTime.Now)
			{
				elapsedTime = elapsedTime.AddYears(100);
			}
			document.ElapsedTime = new DateTimeEx(elapsedTime, Formats.DATE_FORMAT);

			document.AddedAsDOCS = true;

			return true;
		}

		/// <summary>
		/// Номер документа, очищенный от всяких лишних символов
		/// </summary>
		public string GetCleanNumber()
		{
			return cleanDocNumberRegex.Replace(Number, "");
		}

		public override bool Equals(object obj)
		{
			var other = obj as DocumentInfoDataItem;
			if (other == null)
			{
				return false;
			}

			return Type == other.Type && Number == other.Number && IssueCountryCode == other.IssueCountryCode && Equals(ElapsedTime, other.ElapsedTime) &&
				AddedAsDOCS == other.AddedAsDOCS && AddedAsFOID == other.AddedAsFOID;
		}

		public DocumentInfoDataItem Copy()
		{
			var result = new DocumentInfoDataItem();

			result.Type = Type;
			result.Number = Number;
			result.IssueCountryCode = IssueCountryCode;
			result.AddedAsDOCS = AddedAsDOCS;
			result.AddedAsFOID = AddedAsFOID;
			result.ElapsedTime = ElapsedTime?.Copy();

			return result;
		}
	}
}