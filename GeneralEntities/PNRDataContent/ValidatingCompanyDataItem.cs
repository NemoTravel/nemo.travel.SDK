using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание переопределённого ВП
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ValidatingCompanyDataItem
	{
		/// <summary>
		/// Код ВП
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Признак переопределённого ВП
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool IsForced { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as ValidatingCompanyDataItem;
			if (other == null)
			{
				return false;
			}

			return Code == other.Code && IsForced == other.IsForced;
		}

		public ValidatingCompanyDataItem Copy()
		{
			var result = new ValidatingCompanyDataItem();

			result.Code = Code;
			result.IsForced = IsForced;

			return result;
		}
	}
}