using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.Ticketing.RequestElements
{
	/// <summary>
	/// Эндорсмент
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Endorsement
	{
		/// <summary>
		/// Исходные текст эндорсмента
		/// </summary>
		protected string text;

		/// <summary>
		/// Номер пассажира, к которому относится данный эндорсмент
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public int? PassNum { get; set; }

		/// <summary>
		/// Текст эндорсмента
		/// </summary>
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public string Text
		{
			get { return Transliteration.CyrillicToLatin(text); }
			set { text = value; }
		}
	}
}