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
		[DataMember(Order = 0, IsRequired = true)]
		public RequestRequisites Requisites { get; set; }

		/// <summary>
		/// ИД юзера, выполняющего запрос
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int UserID { get; set; }

		/// <summary>
		/// Тип инициализации запроса
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
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