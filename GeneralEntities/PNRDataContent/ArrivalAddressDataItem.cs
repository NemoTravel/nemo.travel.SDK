using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание адреса пребывания в стране прибытия
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ArrivalAddressDataItem
	{
		/// <summary>
		/// Код страны
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string CountryCode { get; set; }

		/// <summary>
		/// Город
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string City { get; set; }

		/// <summary>
		/// Штат/область
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string State { get; set; }

		/// <summary>
		/// Адрес внутри города (районе, улица, дом)
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public string StreetAddress { get; set; }

		/// <summary>
		/// Почтовый код
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string PostalCode { get; set; }

		public ArrivalAddressDataItem()
		{ }

		/// <summary>
		/// Создание нового объекта с заполнением значений на основании SSR DOCA строки
		/// </summary>
		/// <param name="docaString">SSR DOCA строка</param>
		/// <param name="supplier">Поставщик, из которого получена строка с данными. Определяет порядок следования данных в строке</param>
		public ArrivalAddressDataItem(string docaString, AviaSuppliers? supplier = null)
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

		public override bool Equals(object obj)
		{
			var other = obj as ArrivalAddressDataItem;
			if (other == null)
			{
				return false;
			}

			return CountryCode == other.CountryCode && City == other.City && State == other.State &&
					StreetAddress == other.StreetAddress && PostalCode == other.PostalCode;
		}

		public ArrivalAddressDataItem Copy()
		{
			var result = new ArrivalAddressDataItem();

			result.CountryCode = CountryCode;
			result.City = City;
			result.State = State;
			result.StreetAddress = StreetAddress;
			result.PostalCode = PostalCode;

			return result;
		}
	}
}