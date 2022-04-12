using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioTagEditor
{
    [System.Xml.Serialization.XmlRoot("smil")]
    public class ZPLXml
    {
        [System.Xml.Serialization.XmlElement("head")]
        public Head head { get; set; }
        public class Head
        {
            [System.Xml.Serialization.XmlElement("meta")]
            public List<Meta_Value> meta_Value { get; set; }
            public class Meta_Value
            {
                [System.Xml.Serialization.XmlAttribute("name")]
                public string Name { get; set; }

                [System.Xml.Serialization.XmlAttribute("content")]
                public string Content { get; set; }
            }

            [System.Xml.Serialization.XmlElement("title")]
            public PlaylistTitle PlaylistTitles { get; set; }
            public class PlaylistTitle
            {
                [System.Xml.Serialization.XmlText]
                public string Title { get; set; }
            }
        }

        [System.Xml.Serialization.XmlElement("body")]
        public Body body { get; set; }
        public class Body
        {
            [System.Xml.Serialization.XmlElement("seq")]
            public Seq seq { get; set; }
            public class Seq
            {
                [System.Xml.Serialization.XmlElement("media")]
                public List<Media_Value> media_Value { get; set; }
                public class Media_Value
                {
                    [System.Xml.Serialization.XmlAttribute("src")]
                    public string MediaSrc { get; set; }

                    [System.Xml.Serialization.XmlAttribute("albumTitle")]
                    public string albumTitle { get; set; }

                    [System.Xml.Serialization.XmlAttribute("albumArtist")]
                    public string albumArtist { get; set; }

                    [System.Xml.Serialization.XmlAttribute("trackTitle")]
                    public string trackTitle { get; set; }

                    [System.Xml.Serialization.XmlAttribute("trackArtist")]
                    public string trackArtist { get; set; }

                    [System.Xml.Serialization.XmlAttribute("duration")]
                    public uint duration { get; set; }
                }
            }
        }
    }
}
