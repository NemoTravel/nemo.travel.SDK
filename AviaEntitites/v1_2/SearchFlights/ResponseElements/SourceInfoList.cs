﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Sources", ItemName = "SourceInfo")]
	public class SourceInfoList : List<SourceInfo>
	{
		public SourceInfoList() { }

		public SourceInfoList(IEnumerable<SourceInfo> value) : base(value) { }
	}
}
