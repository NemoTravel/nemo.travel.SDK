using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Traveller
{
	/// <summary>
	/// Информация о месте пребывания в стране прилёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class ArrivalAddress
	{
		/// <summary>
		/// Город
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string City { get; set; }

		/// <summary>
		/// Штат/область
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string State { get; set; }

		/// <summary>
		/// Адрес внутри города (районе, улица, дом)
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public string StreetAddress { get; set; }

		/// <summary>
		/// Почтовый код
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public string PostalCode { get; set; }

		/// <summary>
		/// Код страны
		/// </summary>
		[DataMember(IsRequired = true, Order = 4)]
		public string CountryCode { get; set; }

		public ArrivalAddress()
		{ }

		/// <summary>
		/// Создание нового объекта с заполнением значений на основании SSR DOCA строки
		/// </summary>
		/// <param name="docaString">SSR DOCA строка</param>
		/// <param name="supplier">Поставщик, из которого получена строка с данными. Определяет порядок следования данных в строке</param>
		public ArrivalAddress(string docaString, AviaSuppliers? supplier = null)
		{
			var tmp = docaString.Split('/');
			int i = 1;
			//ибо только Сэйбр на данный момент добавляет в SSR строку статус SSRки
			if (supplier.HasValue && supplier.Value == AviaSuppliers.Sabre)
			{
				i = 2;
			}

			if (tmp.Length > i)
			{
				CountryCode = tmp[i];
			}
			if (tmp.Length > i + 1)
			{
				StreetAddress = tmp[i + 1];
			}
			if (tmp.Length > i + 2)
			{
				City = tmp[i + 2];
			}
			if (tmp.Length > i + 3)
			{
				State = tmp[i + 3];
			}
			if (tmp.Length > i + 4)
			{
				PostalCode = tmp[i + 4];
			}
		}
	}
}