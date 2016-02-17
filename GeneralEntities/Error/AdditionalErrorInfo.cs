using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GeneralEntities.Error
{
	/// <summary>
	/// Содержит описание формата дополнительной информации об ошибке
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetSchema")]
	//[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", Name = "AdditionalInfo", ItemName = "InfoItem", KeyName = "InfoKey", ValueName = "InfoValue")]
	public class AdditionalErrorInfo : Dictionary<AdditionalErrorInfoType, string>, IXmlSerializable
	{
		const string NAMESPACE = "http://nemo-ibe.com/STL";

		public AdditionalErrorInfo() { }

		public AdditionalErrorInfo(AdditionalErrorInfoType infoType, string value)
		{
			base.Add(infoType, value);
		}


		#region IXmlSerializable

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			bool wasEmpty = reader.IsEmptyElement;
			reader.Read();
			if (wasEmpty)
				return;
			while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
			{
				reader.ReadStartElement("InfoItem", NAMESPACE);
				reader.ReadStartElement("InfoKey", NAMESPACE);
				var key = (AdditionalErrorInfoType)Enum.Parse(typeof(AdditionalErrorInfoType), reader.ReadContentAsString());
				reader.ReadEndElement();
				reader.ReadStartElement("InfoValue", NAMESPACE);
				var value = reader.ReadContentAsString();
				reader.ReadEndElement();
				this.Add(key, value);
				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}

		public void WriteXml(XmlWriter writer)
		{
			foreach (var key in this.Keys)
			{
				writer.WriteStartElement("InfoItem", NAMESPACE);
				writer.WriteStartElement("InfoKey", NAMESPACE);
				writer.WriteValue(key.ToString());
				writer.WriteEndElement();
				writer.WriteStartElement("InfoValue", NAMESPACE);
				var value = this[key];
				writer.WriteValue(value);
				writer.WriteEndElement();
				writer.WriteEndElement();
			}
		} 

		#endregion


		public static XmlSchemaComplexType GetSchema(XmlSchemaSet schemas)
		{
			string XmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

			var schema = schemas.Schemas(NAMESPACE).OfType<XmlSchema>().FirstOrDefault();
			if (schema == null)
			{
				schema = new XmlSchema
				{
					TargetNamespace = NAMESPACE,
					ElementFormDefault = XmlSchemaForm.Qualified
				};
				schemas.Add(schema);
			}

			var seq = new XmlSchemaSequence();
			seq.Items.Add(new XmlSchemaElement
			{
				Name = "InfoKey",
				SchemaTypeName = new XmlQualifiedName("AdditionalErrorInfoType", NAMESPACE)
			});
			seq.Items.Add(new XmlSchemaElement
			{
				Name = "InfoValue",
				SchemaTypeName = new XmlQualifiedName("string", XmlSchemaNamespace)
			});

			var infoItemElement = new XmlSchemaElement
			{
				Name = "InfoItem",
				MinOccurs = 0,
				MaxOccursString = "unbounded",
				SchemaType = new XmlSchemaComplexType
				{
					Particle = seq
				}
			};

			seq = new XmlSchemaSequence();
			seq.Items.Add(infoItemElement);

			var additionalInfoType = new XmlSchemaComplexType
			{
				Name = "AdditionalInfo",
				Particle = seq
			};

			var doc = new XmlDocument();
			var isDict = doc.CreateElement("IsDictionary", "http://schemas.microsoft.com/2003/10/Serialization/");
			isDict.InnerText = "true";
			var annotation = new XmlSchemaAnnotation();
			annotation.Items.Add(new XmlSchemaAppInfo() { Markup = new[] { isDict } });

			additionalInfoType.Annotation = annotation;


			schema.Items.Add(additionalInfoType);
			schema.Items.Add(new XmlSchemaElement
			{
				Name = "AdditionalInfo",
				IsNillable = true,
				SchemaTypeName = new XmlQualifiedName("AdditionalInfo", NAMESPACE)
			});

			var exporter = new XsdDataContractExporter();
			exporter.Export(typeof(AdditionalErrorInfoType));
			foreach (XmlSchema sch in exporter.Schemas.Schemas(NAMESPACE))
			{
				foreach (var item in sch.Items)
				{
					schema.Items.Add(item);
				}
			}

			

			return additionalInfoType;
		}
	}
}