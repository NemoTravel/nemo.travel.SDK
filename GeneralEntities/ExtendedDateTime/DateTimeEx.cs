using GeneralEntities.Static;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GeneralEntities.ExtendedDateTime
{
	/// <summary>
	/// Класс-обёртка для унификации сериализации времени
	/// </summary>
	[Serializable]
	[JsonConverter(typeof(ExtendedDateTimeJSONConverter))]
	[XmlSchemaProviderAttribute("GetTypeForXMLScheme")]
	public class DateTimeEx : ISerializable, IXmlSerializable, IComparable, ICloneable
	{
		/// <summary>
		/// Штамп времени, оборачиваемый данным экземпляром
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public DateTimeOffset DateTime { get; set; }

		/// <summary>
		/// Часовой пояс
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public double UTCOffset
		{
			get
			{
				return DateTime.Offset.TotalHours;
			}
		}

		/// <summary>
		/// Дата в данном дато-времени
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public DateTime Date
		{
			get
			{
				return DateTime.Date;
			}
		}

		/// <summary>
		/// Формат по которому следует (де)сериализовать экземпляр.
		/// По умолчанию: SharedAssembly.Formats.DATE_TIME_FORMAT (yyyy-MM-ddTHH:mm:ss)
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public string OutFormat { get; set; }

		/// <summary>
		/// Локаль строки в датой и временем
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public CultureInfo OutLocale { get; set; }

		/// <summary>
		/// ИД временной зоны, в которой находится данное дата-время
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public string TimeZoneID { get; set; }

		/// <summary>
		/// Текущее дата и время
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public static DateTimeEx Now
		{
			get
			{
				return new DateTimeEx(DateTimeOffset.Now, Formats.FULL_DATE_TIME_FORMAT);
			}
		}

		#region Конструкторы

		/// <summary>
		/// Безпараметровый конструктор для сериализатора
		/// </summary>
		public DateTimeEx()
		{
			OutFormat = Formats.DATE_TIME_FORMAT;
			OutLocale = Locale.UsCulture;
			TimeZoneID = TimeZoneInfo.Local.Id;
		}

		/// <summary>
		/// Создание объекта на основании строки с датой и временем и предпочитаемого выходного формата
		/// </summary>
		/// <param name="dateTime">Дата и время, на основании которых должен быть создан объект</param>
		/// <param name="outFormat">Предпочитаемый выходной формат даты и времени</param>
		/// <param name="inFormat">Формат входной строки с датой и временем</param>
		/// <param name="offset">Смещение часового пояса для дато-времени</param>
		/// <param name="timeZoneID">ИД временной зоны, в которой находится данное дата-время</param>
		/// <param name="inLocale">Локаль входной строки с датой временем</param>
		/// <param name="outLocale">Локаль выходной строки с датой временем</param>
		public DateTimeEx(string dateTime, string outFormat = Formats.DATE_TIME_FORMAT, string inFormat = null, TimeSpan? offset = null, string timeZoneID = null, CultureInfo inLocale = null, CultureInfo outLocale = null)
		{
			if (string.IsNullOrEmpty(dateTime))
			{
				DateTime = DateTimeOffset.MaxValue;
				TimeZoneID = TimeZoneInfo.Local.Id;
			}
			else
			{
				DateTimeOffset parsedDT;
				if (string.IsNullOrEmpty(inFormat))
				{
					parsedDT = DateTimeOffset.Parse(dateTime);
				}
				else
				{
					parsedDT = DateTimeOffset.ParseExact(dateTime, inFormat, inLocale ?? Locale.UsCulture);
				}

				if (offset.HasValue)
				{
					DateTime = new DateTimeOffset(parsedDT.DateTime, offset.Value);
				}
				else
				{
					DateTime = parsedDT;
				}

				if (timeZoneID != null)
				{
					DateTime = new DateTimeOffset(parsedDT.DateTime, TimeZoneCache.GetTimeZoneByID(timeZoneID).GetUtcOffset(parsedDT));
					TimeZoneID = timeZoneID;
				}
				else
				{
					TimeZoneID = TimeZoneInfo.Local.Id;
				}
			}
			OutFormat = outFormat;
			if (outLocale == null)
			{
				OutLocale = Locale.UsCulture;
			}
		}

		/// <summary>
		/// Класс-обёртка для унификации сериализации времени
		/// </summary>
		/// <param name="dateTime">Штамп времени, оборачиваемый данным экземпляро</param>
		/// <param name="outFormat">Формат по которому следует (де)сериализовать экземпляр.</param>
		/// <param name="outLocale">Локаль выходной строки с датой временем</param>
		/// <param name="timeZoneID">ИД временной зоны, в которой находится данное дата-время</param>
		public DateTimeEx(DateTimeOffset dateTime, string outFormat = Formats.DATE_TIME_FORMAT, CultureInfo outLocale = null, string timeZoneID = null)
		{
			DateTime = dateTime;
			if (timeZoneID != null)
			{
				DateTime = new DateTimeOffset(dateTime.DateTime, TimeZoneCache.GetTimeZoneByID(timeZoneID).GetUtcOffset(dateTime));
				TimeZoneID = timeZoneID;
			}
			else
			{
				TimeZoneID = TimeZoneInfo.Local.Id;
			}
			OutFormat = outFormat;
			if (outLocale == null)
			{
				OutLocale = Locale.UsCulture;
			}
		}

		/// <summary>
		/// Класс-обёртка для унификации сериализации времени
		/// </summary>
		/// <param name="year">Год</param>
		/// <param name="month">Месяц</param>
		/// <param name="day">День</param>
		/// <param name="hour">Час</param>
		/// <param name="minute">Минута</param>
		/// <param name="seconds">Секунда</param>
		/// <param name="outFormat">Формат по которому следует (де)сериализовать экземпляр.</param>
		/// <param name="outLocale">Локаль выходной строки с датой временем</param>
		public DateTimeEx(int year, int month, int day, int hour, int minute, int seconds, string timeZoneID = null, string outFormat = Formats.DATE_TIME_FORMAT, CultureInfo outLocale = null)
		{
			DateTime = new DateTimeOffset(year, month, day, hour, minute, seconds, DateTimeOffset.Now.Offset);
			TimeZoneID = TimeZoneInfo.Local.Id;

			if (timeZoneID != null)
			{
				DateTime = new DateTimeOffset(DateTime.DateTime, TimeZoneCache.GetTimeZoneByID(timeZoneID).GetUtcOffset(DateTime));
				TimeZoneID = timeZoneID;
			}

			OutFormat = outFormat;
			if (outLocale == null)
			{
				OutLocale = Locale.UsCulture;
			}
		}

		/// <summary>
		/// Конструктор для десериализатора
		/// </summary>
		protected DateTimeEx(SerializationInfo info, StreamingContext context)
		{
			DateTime = DateTimeOffset.Parse(info.GetString("DateTime"));
		}

		#endregion

		#region Методы для изменения значений даты и времени

		/// <summary>
		/// Добавляет указанное количество дней к текущему объекту даты и времени и возвращает итоговое значение
		/// </summary>
		/// <param name="dayCount">Количество дней, которое требуется прибавить</param>
		/// <returns>Итог операции</returns>
		public DateTimeEx AddDays(double dayCount)
		{
			return new DateTimeEx(DateTime.AddDays(dayCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx AddHours(double hourCount)
		{
			return new DateTimeEx(DateTime.AddHours(hourCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx AddMinutes(double minutesCount)
		{
			return new DateTimeEx(DateTime.AddMinutes(minutesCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx AddSeconds(double secondsCount)
		{
			return new DateTimeEx(DateTime.AddSeconds(secondsCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx AddTicks(long ticksCount)
		{
			return new DateTimeEx(DateTime.AddTicks(ticksCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx AddMonths(int monthCount)
		{
			return new DateTimeEx(DateTime.AddMonths(monthCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx AddYears(int yearCount)
		{
			return new DateTimeEx(DateTime.AddYears(yearCount), OutFormat, OutLocale, TimeZoneID);
		}

		public DateTimeEx ConvertToLocalTimeZone()
		{
			if (TimeZoneID == TimeZoneInfo.Local.Id)
			{
				return this;
			}

			var targetTimeZoneID = TimeZoneInfo.Local.Id;

			var tzDiff = TimeZoneCache.GetTimeZoneByID(targetTimeZoneID).GetUtcOffset(DateTime) - TimeZoneCache.GetTimeZoneByID(TimeZoneID).GetUtcOffset(DateTime);
			var result = new DateTimeEx((DateTime + tzDiff), timeZoneID: targetTimeZoneID);

			result.OutFormat = OutFormat;
			result.OutLocale = OutLocale;

			return result;
		}

		public DateTimeEx ConvertToTimeZone(string targetTimeZoneID)
		{
			DateTimeEx result = null;

			if (!string.IsNullOrEmpty(targetTimeZoneID))
			{
				var tzDiff = TimeZoneCache.GetTimeZoneByID(targetTimeZoneID).GetUtcOffset(DateTime) - TimeZoneCache.GetTimeZoneByID(TimeZoneID).GetUtcOffset(DateTime);
				result = new DateTimeEx((DateTime + tzDiff), timeZoneID: targetTimeZoneID);
			}
			else
			{
				result = new DateTimeEx(DateTime);
			}

			result.OutFormat = OutFormat;
			result.OutLocale = OutLocale;

			return result;
		}

		#endregion

		#region Перегрузка операторов

		/// <summary>
		/// Неявное приведение расширенного датывремени в обычное
		/// </summary>
		/// <param name="dateTime">Расширенное датывремя</param>
		/// <returns>Обычное датавремя</returns>
		public static implicit operator DateTimeOffset(DateTimeEx dateTime)
		{
			return dateTime.DateTime;
		}

		/// <summary>
		/// Неявное приведение обычного датывремени в расширенное
		/// </summary>
		/// <param name="dateTime">Обычное датывремя</param>
		/// <returns>Расширенное датавремя</returns>
		public static implicit operator DateTimeEx(DateTimeOffset dateTime)
		{
			return new DateTimeEx(dateTime);
		}

		/// <summary>
		/// Неявное приведение обычного датывремени в расширенное
		/// </summary>
		/// <param name="dateTime">Обычное датавремя</param>
		/// <returns>Расширенное датавремя</returns>
		public static implicit operator DateTimeEx(DateTime dateTime)
		{
			return new DateTimeEx(dateTime);
		}

		/// <summary>
		/// Неявное приведение расширенного датавремени в обычное
		/// </summary>
		/// <param name="dateTime">Расширенное датавремя</param>
		/// <returns>Обычное датавремя</returns>
		public static implicit operator DateTime(DateTimeEx dateTime)
		{
			return dateTime.DateTime.LocalDateTime;
		}

		/// <summary>
		/// Перегрузка оператора вычитания
		/// </summary>
		/// <param name="dateTimeA">Время, из которого вычитаем</param>
		/// <param name="dateTimeB">Время, которое вычитаем</param>
		/// <returns>Разница между двумя временами</returns>
		public static TimeSpan operator -(DateTimeEx dateTimeA, DateTimeEx dateTimeB)
		{
			return dateTimeA.DateTime - dateTimeB.DateTime;
		}

		/// <summary>
		/// Перегрузка оператора вычитания
		/// </summary>
		/// <param name="dateTimeA">Время, из которого вычитаем</param>
		/// <param name="dateTimeB">Время, которое вычитаем</param>
		/// <returns>Разница между двумя временами</returns>
		public static TimeSpan operator -(DateTimeEx dateTimeA, DateTime dateTimeB)
		{
			return dateTimeA.DateTime - dateTimeB;
		}

		/// <summary>
		/// Перегрузка оператора вычитания
		/// </summary>
		/// <param name="dateTimeA">Время, из которого вычитаем</param>
		/// <param name="dateTimeB">Время, которое вычитаем</param>
		/// <returns>Разница между двумя временами</returns>
		public static TimeSpan operator -(DateTime dateTimeA, DateTimeEx dateTimeB)
		{
			return dateTimeA - dateTimeB.DateTime;
		}

		/// <summary>
		/// Перегрузка оператора вычитания промежутка времени из даты-времени
		/// </summary>
		/// <param name="dateTime">Исходное дата-время</param>
		/// <param name="timeSpan">Вычитаемый промежуток времени</param>
		/// <returns>Итоговое дата-время</returns>
		public static DateTimeEx operator -(DateTimeEx dateTime, TimeSpan timeSpan)
		{
			return new DateTimeEx(dateTime.DateTime - timeSpan, dateTime.OutFormat, dateTime.OutLocale, dateTime.TimeZoneID);
		}

		/// <summary>
		/// Перегрузка оператора прибавления промежутка времени к дате-времени
		/// </summary>
		/// <param name="dateTime">Исходное дата-время</param>
		/// <param name="timeSpan">Прибавляемый промежуток времени</param>
		/// <returns>Итоговое дата-время</returns>
		public static DateTimeEx operator +(DateTimeEx dateTime, TimeSpan timeSpan)
		{
			return new DateTimeEx(dateTime.DateTime + timeSpan, dateTime.OutFormat, dateTime.OutLocale, dateTime.TimeZoneID);
		}

		#endregion

		/// <summary>
		/// Получение даты и времени в строке предопределённого предпочитаемого формата
		/// </summary>
		/// <returns>Дата и время в строке предпочитаемого формата</returns>
		public override string ToString()
		{
			return ToString(OutFormat, OutLocale);
		}

		/// <summary>
		/// Получение даты и времени в строке предопределённого предпочитаемого формата
		/// </summary>
		/// <param name="format">Желаемый формат даты и времени</param>
		/// <param name="outLocale">Локаль, в которой должна быть итоговая строка</param>
		/// <returns>Дата и время в строке предпочитаемого формата</returns>
		public string ToString(string format, CultureInfo outLocale = null)
		{
			return DateTime.ToString(format, outLocale != null ? outLocale : OutLocale).ToUpper();
		}

		public object Clone()
		{
			var result = new DateTimeEx(DateTime);

			result.OutFormat = this.OutFormat;
			result.OutLocale = this.OutLocale;
			result.TimeZoneID = this.TimeZoneID;

			return result;
		}

		public int CompareTo(object obj)
		{
			var tmp = obj as DateTimeEx;
			if (tmp == null || this.DateTime > tmp.DateTime)
			{
				return 1;
			}
			else if (this.DateTime == tmp.DateTime)
			{
				return 0;
			}
			else
			{
				return -1;
			}
		}

		#region Методы для сериализаторов

		/// <summary>
		/// Метод вызывается при сериализации
		/// </summary>
		[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("DateTime", this.ToString());
		}

		#region реализация IXmlSerializable

		public XmlSchema GetSchema()
		{
			return null; //Так надо по спецификации!
		}

		public void ReadXml(XmlReader reader)
		{
			string strContent = null;

			try
			{
				strContent = reader.ReadElementContentAsString();
			}
			catch
			{
				try
				{
					strContent = reader.ReadElementString();
				}
				catch
				{
					try
					{
						strContent = reader.ReadContentAsString();
					}
					catch (Exception ex)
					{
						//AddCasus.Error("Не удалось достать строку из блока CDATA или ещё более страшная ошибка сериализации", CasusImportance.High, ex);
					}
				}
			}

			if (strContent == null)
			{
				throw new Exception("Не удалось прочитать контент");
			}

			if (string.IsNullOrWhiteSpace(strContent))
			{
				throw new FormatException("Дата и время не могут быть пустой строкой или состоять только из пробелов.");
			}

			DateTime = DateTimeOffset.Parse(strContent);
		}

		public void WriteXml(XmlWriter writer)
		{
			try
			{
				writer.WriteValue(this.ToString());
			}
			catch (Exception ex)
			{
				//AddCasus.Error("Не удалось записать строку в блок CDATA", CasusImportance.High, ex);
			}
		}

		#endregion

		public static DateTimeEx ParseJson(string json)
		{
			if (string.IsNullOrWhiteSpace(json))
			{
				return null;
			}
			return new DateTimeEx(json, Formats.FULL_DATE_TIME_FORMAT);
		}

		public static XmlQualifiedName GetTypeForXMLScheme(XmlSchemaSet xs)
		{
			return new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
		}

		#endregion
	}
}