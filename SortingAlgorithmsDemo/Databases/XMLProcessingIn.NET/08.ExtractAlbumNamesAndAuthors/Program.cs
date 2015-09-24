using System;
/*
 * 8. Write a program, which (using XmlReader and XmlWriter) reads the 
 * file catalog.xml and creates the file album.xml, in which stores 
 * in appropriate way the names of all albums and their authors.
 */
using System.Xml;

namespace _08.ExtractAlbumNamesAndAuthors
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = XmlReader.Create("..//..//albums.xml"))
            {
                using (var writer = XmlWriter.Create("..//..//albumNamesAndAuthors.xml"))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("albumNamesAndAuthors", "urn:albumNamesAndAuthors");

                    var albumName = String.Empty;
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name=="name")
                            {
                                 albumName = reader.ReadElementString();
                            }
                            else if (reader.Name == "artist")
                            {
                                 var artistName = reader.ReadElementString();

                                 writer.WriteStartElement("album");
                                 writer.WriteElementString("name", albumName);
                                 writer.WriteElementString("artist", artistName);

                                 writer.WriteEndElement();
                            }
                        }
                    }
                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                }
            }
        }
    }
}
