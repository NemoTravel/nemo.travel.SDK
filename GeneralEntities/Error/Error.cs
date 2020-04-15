using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace GeneralEntities.Error
{
	/// <summary>
	/// Содержит информацию об ошибке, возникшей в процессе работы сервера
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Error
	{
		/// <summary>
		/// Уровень ошибки
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		[DefaultValue(ErrorLevels.Runtime)]
		public ErrorLevels Level { get; set; }

		/// <summary>
		/// Код ошибки
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public ushort Code { get; set; }

		/// <summary>
		/// Сообщение об ошибке от сервера
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public string Message { get; set; }

		/// <summary>
		/// Сервисное сообщение об ошибке. Заполняется в случае если ошибка была получена от внешних источников данных.
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string ServiceMessage { get; set; }

		/// <summary>
		/// Дополнительная информаци об ошибке
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public AdditionalErrorInfo AdditionalInfo { get; set; }

		/// <summary>
		/// Стэктрейс из исключения, на основе которого была сгенерированна данная ошибка. Используется для статистики
		/// </summary>
		[IgnoreDataMember]
		public string StackTrace { get; set; }

		public Error()
		{
		}

		public Error(string message, ushort code = CommonErrorCodes.SYSTEM_ERROR, string serviceMessage = null, ErrorLevels level = ErrorLevels.Runtime)
		{
			Message = message;
			Code = code;
			ServiceMessage = serviceMessage;
			Level = level;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Level.GetHashCode() + Code.GetHashCode() + Message.GetHashCode() + (ServiceMessage == null ? 0 : ServiceMessage.GetHashCode());
			}
		}

		public override bool Equals(object obj)
		{
			var other = obj as Error;
			return other != null
				&& Level == other.Level
				&& Code == other.Code
				&& Message == other.Message
				&& ServiceMessage == other.ServiceMessage;
		}
	}
}