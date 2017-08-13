using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.RequestElements
{
	/// <summary>
	/// АПИ обёртка для списка допопераций
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Operation")]
	public class OperationList : List<AdditionalOperation>
	{
		public OperationList()
		{ }

		public OperationList(IEnumerable<AdditionalOperation> operationList)
			: base(operationList)
		{ }
	}
}