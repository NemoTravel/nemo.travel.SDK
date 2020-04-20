using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TourCodeDataItem
	{
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public TourCodeType Type { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public string Value { get; set; }

		public override bool Equals(object obj)
		{
			var otherItem = obj as TourCodeDataItem;
			return otherItem != null && otherItem.Type == Type && otherItem.Value == Value;
		}

		public bool Equals(object obj, bool compareType)
		{
			var otherItem = obj as TourCodeDataItem;
			return otherItem != null && (!compareType || otherItem.Type == Type) && otherItem.Value == Value;
		}

		public TourCodeDataItem Copy()
		{
			var result = new TourCodeDataItem();

			result.Type = Type;
			result.Value = Value;

			return result;
		}
	}
}