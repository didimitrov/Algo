using System;
using System.Xml.Linq;

namespace XmlBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlStudents = XElement.Load("../../Students.xml");
            Console.WriteLine(xmlStudents);
        }
    }
}
