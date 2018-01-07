using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XML_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            Item item = new Item();
            String xmlString = File.ReadAllText("XML.xml");
            XmlDocument document = new XmlDocument();
            document.Load("XML.xml");
            var root = document.DocumentElement;
            foreach (XmlNode child in root.ChildNodes)
            {
                item.Title = root.Attributes["news"].InnerXml;
                item.Link = root.Attributes["link"].InnerText;
                item.Description = root.Attributes["description"].InnerText;
                item.PubDate = root.Attributes["pubDate"].InnerText;
            }
            Console.ReadLine();

        }
    }
}
