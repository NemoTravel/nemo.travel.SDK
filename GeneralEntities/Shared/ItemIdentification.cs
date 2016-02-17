using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	/// <summary>
	/// Базовый класс, содержащий поля для идентификации элементов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class ItemIdentification<T>
	{
		/// <summary>
		/// Идентификатор элемента.
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public virtual T ID { get; set; }
	}


	public static class ItemIdentificationExtension
	{
		/// <summary>
		/// Метод для безопасного  получения идентификатора (с проверкой на то что объект может быть пустым)
		/// </summary>
		/// <remarks>Рекомендуется к использованию при добавлении казуса в телеметрии</remarks>
		/// <returns>obj != null ? obj.ID : (int?)null</returns>
		public static int? TryGetID(this ItemIdentification<int> obj)
		{
			return obj != null ? obj.ID : (int?)null;
		}


		/// <summary>
		/// Метод для безопасного  получения идентификатора (с проверкой на то что объект может быть пустым)
		/// </summary>
		/// <remarks>Рекомендуется к использованию при добавлении казуса в телеметрии</remarks>
		/// <returns>obj != null ? obj.ID : (long?)null</returns>
		public static long? TryGetID(this ItemIdentification<long> obj)
		{
			return obj != null ? obj.ID : (long?)null;
		}
	}
}