/*
 * 11. Write a program, which extract from the file catalog.xml the 
 * prices for all albums, published 5 years ago or earlier Use XPath query.
 */

using System;
using System.Xml;

namespace _11.FindPricesOfAlbums
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("../../../albums.xml");

            var query = "albums/album[year<2009]";
            var albums = doc.SelectNodes(query);

            foreach (XmlNode album in albums)
            {
                string albumName = album.SelectSingleNode("name").InnerText;
                string price = album.SelectSingleNode("price").InnerText;

                Console.WriteLine("Album {0} costs: -> {1}", albumName, price);
            }
        }
    }
}
