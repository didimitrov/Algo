using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace _02.PrintNumberOfAlbumsForArtist
{
    class Program
    {
        private static void Main(string[] args)
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("..//..//albums.xml");

            var root = xmlDocument.DocumentElement;
            var dictionary = new Dictionary<string, int>();

            foreach (XmlNode node in root.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (!dictionary.ContainsKey(artistName))
                {
                    dictionary.Add(artistName, 0);
                }
                else
                {
                    dictionary[artistName]++;
                }
            }

            foreach (var i in dictionary)
            {
                Console.WriteLine("{0} - {1} ",i.Key, i.Value);
            }
        }
    }
}
