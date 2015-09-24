using System;
using System.IO;
using System.Xml;

namespace _07.ExtractPeopleInfoToXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("..//..//people.txt"))
            {
                using (var writer = XmlWriter.Create("..//..//people.xml"))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("people","urn:people");

                    var line = reader.ReadLine();

                    while (line!=null)
                    {
                        var splitedLine = line.Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);

                        var name = splitedLine[0];
                        var address = splitedLine[1];
                        var phone = splitedLine[2];

                        writer.WriteStartElement("person");
                        writer.WriteElementString("name",name);
                        writer.WriteElementString("address", address);
                        writer.WriteElementString("phone", phone);

                        writer.WriteEndElement();

                        line = reader.ReadLine();
                    }

                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                }
            }
        }
    }
}
