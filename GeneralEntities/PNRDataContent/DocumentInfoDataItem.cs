using GeneralEntities.ExtendedDateTime;
using SharedAssembly;
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class DocumentInfoDataItem
	{
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
		/// Создание нового объекта и заполнение его данными из SSR DOCS строки
		/// </summary>
		/// <param name="docsString">SSR DOCS строка</param>
		/// <param name="supplier">Поставщик, из которого была получена SSR DOCS строка</param>
		public DocumentInfoDataItem(string docsString, AviaSuppliers? supplier = null)
		{
			int index = 0;
			//ибо только Сэйбр на данный момент добавляет в SSR строку статус SSRки
			if (supplier.HasValue && supplier.Value == AviaSuppliers.Sabre)
			{
				index = 1;
			}
			var tmp = docsString.Split('/');

			Type = (DocTypes)Enum.Parse(typeof(DocTypes), tmp[index]);
			Number = tmp[index + 2];
			IssueCountryCode = tmp[index + 1];

			var tmpElapsedDate = DateTime.Parse(tmp[index + 6], Locale.UsCulture);
			if (tmpElapsedDate < DateTime.Now)
			{
				tmpElapsedDate = tmpElapsedDate.AddYears(100);
			}
			ElapsedTime = new DateTimeEx(tmpElapsedDate, Formats.DATE_FORMAT);

			AddedAsDOCS = true;
		}

		/// <summary>
		/// Номер документа, очищенный от всяких лишних символов
		/// </summary>
		public string GetCleanNumber()
		{
			return Regex.Replace(Number, @"[^\w|^а-яА-ЯЁё]", "");
		}
	}
}