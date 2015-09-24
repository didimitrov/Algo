using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace _06.ExtractSongTitlesWithXDocument
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var doc = XDocument.Load("..//..//albums.xml");

            var songTitles = doc.Descendants("song").Select(x => x.Element("title").Value);

            using (var xmlWriter = XmlWriter.Create("../../extrrTitles.xml"))
            {
                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("songs", "urn:songs");

                foreach (var title in songTitles)
                {
                    xmlWriter.WriteStartElement("song");

                    xmlWriter.WriteElementString("title", title);

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
            }
        }
    }
}
