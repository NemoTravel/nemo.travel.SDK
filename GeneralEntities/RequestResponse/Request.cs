using GeneralEntities.Lib;
using System.Runtime.Serialization;

namespace GeneralEntities
{
	/// <summary>
	/// Базовый класс для всех запросов к серверам (кроме роутинг-сервера)
	/// </summary>	
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Request
	{
		/// <summary>
		/// Реквизиты доступа
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public RequestRequisites Requisites { get; set; }

		/// <summary>
		/// ИД юзера, выполняющего запрос
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public int UserID { get; set; }

		/// <summary>
		/// Тип инициализации запроса
		/// </summary>
		[DataMember(IsRequired = false, Order = 2)]
		public RequestTypes RequestType { get; set; }
	}

	/// <summary>
	/// Базовый класс для запросов к серверам (кроме роутинг-сервера) с универсальным типом тела
	/// </summary>
	/// <typeparam name="T">Тип тела конкретного запроса</typeparam>
	[DataContract(Name = "RequestWith{0}", Namespace = "http://nemo-ibe.com/STL")]
	public class Request<T> : Request
	{
		/// <summary>
		/// Тело запроса
		/// </summary>
		[DataMember(IsRequired = true)]
		public T RequestBody { get; set; }
	}
}