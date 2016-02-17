using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Содержит информацию об EMD
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class EMDInfo
	{
		/// <summary>
		/// Номер документа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Тип услуги, на который этот документ применяется
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Service { get; set; }

		/// <summary>
		/// ТЛ на выполнение услуги
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public DateTimeEx ExecutionTimeLimit { get; set; }
	}
}
