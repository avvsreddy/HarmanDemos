using System.Xml.Linq;

namespace LinqDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // load
            XDocument xml = XDocument.Load("XMLFile1.xml");

            // select all book titles belongs to computer

            var titles = (from b in xml.Descendants("book")
                          where b.Element("genre").Value == "Computer"
                          select b.Element("title").Value);

            foreach (var title in titles) { Console.WriteLine(title); }
            //Console.WriteLine(titles);
        }
    }
}
