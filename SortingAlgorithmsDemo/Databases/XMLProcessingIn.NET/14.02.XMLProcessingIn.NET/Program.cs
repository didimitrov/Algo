using System.Xml.Xsl;

namespace _14._02.XMLProcessingIn.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../albums.xslt");
            xslt.Transform("../../albums.xml", "../../albums.html");
        }
    }
}
