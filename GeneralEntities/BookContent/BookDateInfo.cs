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
	}
}