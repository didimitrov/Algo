using System;
using System.Linq;
using System.Xml.Linq;

namespace _12.FindPricesOfAlbumsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = XDocument.Load("../../../albums.xml");

            var albums = doc.Descendants("album")
                .Where(a => int.Parse(a.Element("year").Value) < 2009)
                .Select(x => new
                {
                    Name = x.Element("name").Value,
                    Price = x.Element("price").Value
                });

            foreach (var album in albums)
            {
                Console.WriteLine("Album {0} costs: -> {1}", album.Name, album.Price);
            }
        }
    }
}
