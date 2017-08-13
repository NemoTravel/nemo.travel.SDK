using System.Diagnostics;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Содержит описание информации о точке путешествия
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[DebuggerDisplay("[{Code}:{CityCode}]")]
	public class TripPointInformation
	{
		/// <summary>
		/// Код точки путешествия (аэропорт, вокзал, отель и т.д.)
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Код структурного элемента точки путешествия - терминал в аэропорту
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string SubPointCode { get; set; }

		/// <summary>
		/// Код города, в котором находится точка путешествия
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string CityCode { get; set; }

		/// <summary>
		/// Часовой пояс точки путешествия на момент путешествия
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public float? UTC { get; set; }


		/// <summary>
		/// Получает код города, если код не указан - возвращает код аэропорта
		/// </summary>
		/// <returns></returns>
		public string GetCityCode()
		{
			return string.IsNullOrEmpty(CityCode) ? Code : CityCode;
		}

		/// <summary>
		/// Получает код аэропорта, если код не указан - возвращает код города
		/// </summary>
		/// <returns></returns>
		public string GetAirportCode()
		{
			return string.IsNullOrEmpty(Code) ? CityCode : Code;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (obj == this)
			{
				return true;
			}

			var tripPointInformation = obj as TripPointInformation;

			if (tripPointInformation != null)
			{
				if (tripPointInformation.Code == this.Code &&
					tripPointInformation.CityCode == this.CityCode &&
					tripPointInformation.SubPointCode == this.SubPointCode)
				{
					return true;
				}
			}

			return false;
		}

		public override int GetHashCode()
		{
			return (Code + CityCode).GetHashCode();
		}
	}
}