using GeneralEntities.Shared;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит эндорсменты брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class EndorsementDataItem
	{
		/// <summary>
		/// Текст эндорсментов
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public TextList EndorsementText { get; set; }

		public override bool Equals(object obj)
		{
			var otherItem = obj as EndorsementDataItem;
			if (otherItem != null)
			{
				if (EndorsementText != null && otherItem.EndorsementText != null && EndorsementText.SequenceEqual(otherItem.EndorsementText))
				{
					return true;
				}
				else
				{
					return EndorsementText == null && otherItem.EndorsementText == null;
				}
			}

			return false;
		}

		public EndorsementDataItem Copy()
		{
			var result = new EndorsementDataItem();

			if (EndorsementText != null)
			{
				result.EndorsementText = new TextList(EndorsementText);
			}

			return result;
		}
	}
}