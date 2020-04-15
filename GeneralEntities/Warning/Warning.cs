using SharedAssembly.Warning.Codes;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Warning
{
	/// <summary>
	/// Содержит описание важного информационного сообщения
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Warning : IEquatable<Warning>
	{
		/// <summary>
		/// Код типа сообщения
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public ushort Code { get; set; }

		/// <summary>
		/// Текст сообщения
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string Message { get; set; }
		
		/// <summary>
		/// Служебная информация
		/// </summary>
		[DataMember(IsRequired = false, Order = 2, EmitDefaultValue = false)]
		public string ServiceMessage { get; set; }

		public Warning()
		{
		}

		public Warning(string message, ushort code = CommonWarningCodes.SYSTEM_ERROR, string serviceMessage = null)
		{
			Message = message;
			Code = code;
			ServiceMessage = serviceMessage;
		}


		public override int GetHashCode()
		{
			unchecked
			{
				return Code.GetHashCode() + Message.GetHashCode() + (ServiceMessage == null ? 0 : ServiceMessage.GetHashCode()); 
			}
		}

		public override bool Equals(object obj)
		{
			var other = obj as Warning;
			return other != null
				&& Code == other.Code
				&& Message == other.Message
				&& ServiceMessage == other.ServiceMessage;
		}

		public bool Equals(Warning other)
		{
			return other != null
				&& Code == other.Code
				&& Message == other.Message
				&& ServiceMessage == other.ServiceMessage;
		}
	}
}