using AviaEntities.Agent_ru.VariantSearch.ResponseElements;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia", TypeName="VariantSearchResponse")]
	public class VariantSearchRS
	{
		public VariantSearchRS()
		{
			responseClassifiers = new ResponseClassifiers();
		}

		[XmlArray(Order = 0)]
		[XmlArrayItem("variant")]
		public List<PricedVariant> pricedVariants { get; set; }

		[XmlElement(Order = 1)]
		public ResponseClassifiers responseClassifiers { get; set; }

		[XmlElement(Order = 2)]
		public ErrorDescriptor descriptor { get; set; }
	}

	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class ErrorDescriptor
	{
		[XmlElement(Order = 0)]
		public string code { get; set; }

		[XmlElement(Order = 1)]
		public string message { get; set; }
	}
}
