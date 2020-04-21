﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.AdditionalOperations.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo.travel/Avia", ItemName = "Service")]
	public class SelectedAncillaryServicesList : List<SelectedAncillaryService>
	{
		public SelectedAncillaryServicesList() : base() { }

		public SelectedAncillaryServicesList(IEnumerable<SelectedAncillaryService> collection) : base(collection) { }
	}
}