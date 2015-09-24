/* 
    * Write program that extracts all different artists which
    * are found in the catalog.xml. For each author you
    * should print the number of albums in the catalogue.
    * Implement the previous using XPath. 
    */

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace _03.NumberOfAlbumsForArtistWithXPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../albums.xml");
            var xPathQuery = "albums/album";

            var albumList = xmlDoc.SelectNodes(xPathQuery);
            var dict = new Dictionary<string, int>();

            foreach (XmlNode album in albumList)
            {
                var artistName = album.SelectSingleNode("artist").InnerText;

                if (dict.ContainsKey(artistName))
                {
                    dict[artistName]++;
                }
                else
                {
                    dict.Add(artistName, 0);
                }
            }

            foreach (var i in dict)
            {
                Console.WriteLine("{0} - {1} ", i.Key, i.Value);
            }
        }
    }
}
