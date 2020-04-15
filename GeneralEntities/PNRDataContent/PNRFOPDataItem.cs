using GeneralEntities.PNRDataContent.FOP;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание формы оплаты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PNRFOPDataItem
	{
		/// <summary>
		/// ФОПы
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PNRFOPList FOPs { get; set; }

		public PNRFOPDataItem Copy()
		{
			var result = new PNRFOPDataItem();

			if (FOPs != null)
			{
				result.FOPs = new PNRFOPList();
				FOPs.ForEach(fop => result.FOPs.Add(fop.Copy()));
			}

			return result;
		}
	}
}