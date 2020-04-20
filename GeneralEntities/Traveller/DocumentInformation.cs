using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace GeneralEntities.Traveller
{
	/// <summary>
	/// Паспортные (или иного документа) данные пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class DocumentInformation
	{
		/// <summary>
		/// Тип документа
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public DocTypes DocType { get; set; }

		/// <summary>
		/// Номер документа
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string DocNum { get; set; }

		/// <summary>
		/// Код страны выдачи
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string CountryCode { get; set; }

		/// <summary>
		/// Дата и время истечения срока действия документа в формате dd.mm.yyyy (например 31.12.2012)
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string DocElapsedTime { get; set; }

		/// <summary>
		/// Номер документа, очищенный от всяких лишних символов
		/// </summary>
		[JsonIgnore]
		[IgnoreDataMember]
		public string CleanDocNum
		{
			get { return Regex.Replace(DocNum, @"[^\w|^а-яА-ЯЁё]", ""); }
		}

		public DocumentInformation()
		{ }

		/// <summary>
		/// Создание нового объекта и заполнение его данными из SSR DOCS строки
		/// </summary>
		/// <param name="docsString">SSR DOCS строка</param>
		/// <param name="supplier">Поставщик, из которого была получена SSR DOCS строка</param>
		public DocumentInformation(string docsString, AviaSuppliers? supplier = null)
		{
			int index = 0;
			//ибо только Сэйбр на данный момент добавляет в SSR строку статус SSRки
			if (supplier.HasValue && supplier.Value == AviaSuppliers.Sabre)
			{
				index = 1;
			}
			var tmp = docsString.Split('/');

			DocType = (DocTypes)Enum.Parse(typeof(DocTypes), tmp[index]);
			DocNum = tmp[index + 2];
			CountryCode = tmp[index + 1];

			var tmpElapsedDate = DateTime.Parse(tmp[index + 6], Locale.UsCulture);
			if (tmpElapsedDate < DateTime.Now)
			{
				tmpElapsedDate = tmpElapsedDate.AddYears(100);
			}
			DocElapsedTime = tmpElapsedDate.ToString(Formats.DATE_FORMAT);
		}
	}
}