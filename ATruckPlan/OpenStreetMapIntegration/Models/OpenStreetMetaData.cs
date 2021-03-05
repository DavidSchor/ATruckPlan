using System;
using System.Xml.Serialization;

namespace OpenStreetMapIntegration.Models
{
    [XmlRoot(ElementName = "addressparts")]
    public class Addressparts
    {
        [XmlElement(ElementName = "tourism")]
        public string Tourism { get; set; }

        [XmlElement(ElementName = "road")]
        public string Road { get; set; }

        [XmlElement(ElementName = "neighbourhood")]
        public string Neighbourhood { get; set; }

        [XmlElement(ElementName = "suburb")]
        public string Suburb { get; set; }

        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        [XmlElement(ElementName = "municipality")]
        public string Municipality { get; set; }

        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        [XmlElement(ElementName = "postcode")]
        public int Postcode { get; set; }

        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "country_code")]
        public string CountryCode { get; set; }
    }

    [XmlRoot(ElementName = "reversegeocode")]
    public class Reversegeocode
    {
        [XmlElement(ElementName = "addressparts")]
        public Addressparts Addressparts { get; set; }

        [XmlAttribute(AttributeName = "timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlAttribute(AttributeName = "attribution")]
        public string Attribution { get; set; }

        [XmlAttribute(AttributeName = "querystring")]
        public string Querystring { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}