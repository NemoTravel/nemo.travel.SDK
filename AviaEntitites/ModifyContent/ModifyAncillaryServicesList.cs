using AviaEntities.SharedElements.Ancillaries.RequestElements;
using GeneralEntities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.ModifyContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "ModifyAncillaryService")]
	public class ModifyAncillaryServicesList : List<ModifyAncillaryService>
	{
		/// <summary>
		/// Допуслуги которые необходимо добавить
		/// </summary>
		public IEnumerable<AncillaryServiceRQ> ToAdd
		{
			get { return Select(PNRContentModifyAction.Add); }
		}

		/// <summary>
		/// Допуслуги которые необходимо модифицировать
		/// </summary>
		public IEnumerable<AncillaryServiceRQ> ToModify
		{
			get { return Select(PNRContentModifyAction.Modify); }
		}

		/// <summary>
		/// Допуслуги которые необходимо удалить
		/// </summary>
		public IEnumerable<AncillaryServiceRQ> ToRemove
		{
			get { return Select(PNRContentModifyAction.Remove); }
		}


		private IEnumerable<AncillaryServiceRQ> Select(PNRContentModifyAction action)
		{
			return this.Where(s => s.Action == action).Select(s => s.AncillaryService);
		}
	}
}