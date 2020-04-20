using GeneralEntities.PNRDataContent.FOP;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание формы оплаты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FOPDataItem
	{
		/// <summary>
		/// ФОПы
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public FOPList FOPs { get; set; }

		/// <summary>
		/// Признак смешанной формы оплаты
		/// </summary>
		[IgnoreDataMember]
		public bool IsMixedFOP
		{
			get
			{
				var twoCC = FOPs.Where(fop => fop.Type == FOPType.CC);
				if (twoCC.Count() == 2)
				{
					return FOPs.Count == 2; // Разрешаем оплату двумя картами.
				}
				else
				{
					return FOPs.Select(fop => fop.Type).Distinct().Count() > 1;
				}
			}
		}

		public override bool Equals(object obj)
		{
			var other = obj as FOPDataItem;
			if (other == null)
			{
				return false;
			}

			return FOPs == null && other.FOPs == null ||
				FOPs != null && other.FOPs != null && FOPs.Count == other.FOPs.Count && FOPs.All(fop => other.FOPs.Contains(fop));
		}

		public FOPDataItem Copy()
		{
			var result = new FOPDataItem();

			if (FOPs != null)
			{
				result.FOPs = new FOPList();
				result.FOPs.AddRange(FOPs.Select(fop => fop.Copy()));
			}

			return result;
		}
	}
}