using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// OSI - Other service information (Прочая служебная информация)
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class OSIDataItem
	{
		/// <summary>
		/// Текст с информацией
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Text { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as OSIDataItem;
			if (other == null)
			{
				return false;
			}

			return Text == other.Text;
		}

		public OSIDataItem Copy()
		{
			var result = new OSIDataItem();

			result.Text = Text;

			return result;
		}
	}
}