using AviaEntities.Agent_ru.VariantSearch.ResponseElements.Classifiers;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class ResponseClassifiers
	{
		[XmlElement(Order = 0)]
		public List<AircompanyClassifier> aircompany { get; set; }

		[XmlElement(Order = 1)]
		public List<CityClassifier> city { get; set; }

		[XmlElement(Order = 2)]
		public List<CountryClassifier> country { get; set; }

		[XmlElement(Order = 3)]
		public List<AircraftClassifier> plane { get; set; }

		[XmlElement(Order = 4)]
		public List<AirportClassifier> airport { get; set; }
	}
}
