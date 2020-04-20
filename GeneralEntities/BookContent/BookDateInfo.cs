using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace GeneralEntities.BookContent
{
	/// <summary>
	/// Содержит информацию о времени возникновения различных событий с бронью
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BookDateInfo
	{
		/// <summary>
		/// Создание брони
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public DateTimeEx Created { get; set; }

		/// <summary>
		/// Дата и время начала выполнения
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public DateTimeEx Start { get; set; }

		/// <summary>
		/// Последнее обновлени
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public DateTimeEx LastUpdate { get; set; }

		/// <summary>
		/// Последний доступ к брони
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx LastAccess { get; set; }

		/// <summary>
		/// Отмена брони
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public DateTimeEx Canceled { get; set; }

		/// <summary>
		/// Выписка брони
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public DateTimeEx Ticketed { get; set; }

		/// <summary>
		/// Войдирование
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public DateTimeEx Voided { get; set; }

		/// <summary>
		/// Оформление возврата
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public DateTimeEx Refunded { get; set; }

		/// <summary>
		/// Оформление обмена
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public DateTimeEx Exchanged { get; set; }

		/// <summary>
		/// Дата и время оплаты
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public DateTimeEx Paid { get; set; }

		/// <summary>
		/// Дата и время разбиения брони
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public DateTimeEx Splited { get; set; }

		/// <summary>
		/// Дата и время снятия мест у выписанной брони
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public DateTimeEx SeatsReleased { get; set; }


		/// <summary>
		/// Простановка даты создание брони на сервере
		/// </summary>
		public void SetCreationDate()
		{
			Created = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты последнего обновления брони
		/// </summary>
		public void SetLastUpdateDate()
		{
			LastUpdate = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты последнего доступа к брони
		/// </summary>
		public void SetLastAccessDate()
		{
			LastAccess = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты выписки брони на сервере
		/// </summary>
		public void SetTicketingDate()
		{
			Ticketed = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты войдирования брони на сервере
		/// </summary>
		public void SetVoidingDate()
		{
			Voided = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты возврата брони на сервере
		/// </summary>
		public void SetRefundDate()
		{
			Refunded = DateTimeEx.Now;
		}

		/// <summary>
		/// Проставление даты разбиения брони на сервере
		/// </summary>
		public void SetSplitDate()
		{
			Splited = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты отмены брони на сервере
		/// </summary>
		public void SetCancelingDate()
		{
			Canceled = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты снятия мест на сервере
		/// </summary>
		public void SetSeatReleaseDate()
		{
			SeatsReleased = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка формата строкового представления при сериализации данных
		/// </summary>
		/// <param name="format">Формат строкового представления</param>
		public void SetOutFormat(string format)
		{
			SetOutFormat(Created, format);
			SetOutFormat(Start, format);
			SetOutFormat(LastUpdate, format);
			SetOutFormat(LastAccess, format);
			SetOutFormat(Canceled, format);
			SetOutFormat(Ticketed, format);
			SetOutFormat(Voided, format);
			SetOutFormat(Refunded, format);
			SetOutFormat(Exchanged, format);
			SetOutFormat(Paid, format);
		}


		private void SetOutFormat(DateTimeEx dateTimeEx, string format)
		{
			if (dateTimeEx != null)
			{
				dateTimeEx.OutFormat = format;			
			}
		}
	}
}