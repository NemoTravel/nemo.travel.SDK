using System;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements
{
	/// <summary>
	/// Результат операции над бронью, содержащий только признак успешности/неуспешности операции
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class BookOperationResult : OnlyBookIDElement
	{
		/// <summary>
		/// Индикатор успеха операции
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public bool Success { get; set; }

		public BookOperationResult() { }

		/// <summary>
		/// Результат операции над бронью, содержащий только признак успешности/неуспешности операции
		/// </summary>
		/// <param name="success">Признак успешности/неуспешности операции</param>
		/// <param name="bookID">ИД брони, над которой выполнялась операция</param>
		public BookOperationResult(bool success, long bookID)
		{
			Success = success;
			BookID = bookID;
		}
	}
}