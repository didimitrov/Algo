using System.Collections.Generic;
using System.Xml;

/*
 * 4. Using the DOM parser write a program to delete from
 * catalog.xml all albums having price > 20.
 */
namespace _04.DeleteAlbums
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("../../albums.xml");

            var rootNode = doc.DocumentElement;

            var albumsToRemove = new List<XmlNode>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var price = double.Parse(node["price"].InnerText);

                if (price>20)
                {
                    albumsToRemove.Add(node);
                }
            }

            foreach (XmlNode node in albumsToRemove)
            {
                rootNode.RemoveChild(node);
            }

            doc.Save("../../albumsNew.xml");
        }
    }
}
