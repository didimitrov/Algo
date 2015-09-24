/*
 * 9. Write a program to traverse given directory and write to a XML
 * file its contents together with all subdirectories and files.
 * Use tags <file> and <dir> with appropriate attributes. 
 * For the generation of the XML document use the class XmlWriter.
 */

using System.IO;
using System.Xml;

namespace _09.TraverseDirectory
{
    class Program
    {
        public static void WriteFilesAndDirectoriesToXml(DirectoryInfo dir, XmlWriter writer)
        {
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("name", dir.Name);

            foreach (var file in dir.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }


            foreach (var subDir in dir.GetDirectories())
            {
                WriteFilesAndDirectoriesToXml(subDir, writer);
            }

            writer.WriteEndElement();
        }

        static void Main(string[] args)
        {
            using (var xmlWriter = XmlWriter.Create("../../directory.xml"))
            {
                string startFolderLocation = "../../";
                var directory = new DirectoryInfo(startFolderLocation);


                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("directories");

                WriteFilesAndDirectoriesToXml(directory, xmlWriter);

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }


    }
}
