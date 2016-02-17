using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace AviaEntities.Lib
{
    /// <summary>
    /// Содержит кучу полей, которые просто хранятся, и при поиске тарифных правил передаются в ГДС
    /// </summary>
    [XmlType]
	[Serializable]
    public class UPT
    {
        protected string _base_fare;

        [XmlElement]
        public string idar1 { get; set; }

        [XmlElement]
        public string addon_ida { get; set; }

        [XmlElement]
        public string ntrip { get; set; }

        [XmlElement]
        public string nvr { get; set; }

        [XmlElement]
        public string code_upt { get; set; }

        [XmlElement]
        public string tariff { get; set; }

        [XmlElement]
        public string main_awk { get; set; }

        [XmlElement]
        public string cat { get; set; }

        [XmlElement]
        public string vcat { get; set; }

        [XmlElement]
        public string city1 { get; set; }

        [XmlElement]
        public string city2 { get; set; }

        [XmlElement]
        public string dport { get; set; }

        [XmlElement]
        public string aport { get; set; }

        [XmlElement]
        public string base_fare
        {
            get { return this._base_fare; }
            set
            {
                //костыль для пробелов в base_fare
                if (value != null)
                {
                    Regex regex = new Regex(@"-*\s*$");
                    this._base_fare = regex.Replace(value, ""); ;
                }
                else
                {
                    this._base_fare = value;
                }
            }
        }
        [XmlElement]
        public string iit { get; set; }

        [XmlElement]
        public string owrt { get; set; }

        [XmlElement]
        public string ddate { get; set; }

        [XmlElement]
        public string fdate { get; set; }

        [XmlElement]
        public string deliv_type { get; set; }

        [XmlElement]
        public string ftnt { get; set; }
    }
}
