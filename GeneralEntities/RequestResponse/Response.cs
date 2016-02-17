using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities
{
	/// <summary>
	/// Ответ сервер на запрос
	/// </summary>
	/// <typeparam name="T">Тип тела ответа</typeparam>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Response
	{
		/// <summary>
		/// ИД запроса к серверу, на который возвращён ответ
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public long RequestID { get; set; }
		
		/// <summary>
		/// Ошибки, возникшие при обработке запроса
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public List<Error.Error> Errors { get; set; }
		
		/// <summary>
		/// Различная дополнительная информация о нестандартных ситуациях,
		/// возникших при обработке запроса, о которых необходимо уведомить пользователя
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public List<Warning.Warning> Warnings { get; set; }
	}

    /// <summary>
	/// Базовый класс для ответов сервера на запрос c универсальным типом тела
	/// </summary>
	/// <typeparam name="T">Тип тела конкретного ответа на запрос</typeparam>
	[DataContract(Name = "ResponseWith{0}", Namespace = "http://nemo-ibe.com/STL")]
    public class Response<T> : Response
    {
        /// <summary>
		/// Тело ответа
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public T ResponseBody { get; set; }
    }
}