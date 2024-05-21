using System.Xml.Linq;

namespace LinqDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>() { "one", "two", "three", "four", "five", "six" };

            // load xml document
            XDocument list = XDocument.Load("E:\\Demos\\Harman\\HarmanDemos\\LinqDemo3\\XMLFile1.xml");

            // extract small words
            //var shortWords = from l in list
            //                 where l.Length <= 3
            //                 select l;

            // LINQ to XML
            var shortWords = from l in list.Descendants("word")
                             where l.Value.Length <= 3
                             select l.Value;

            foreach (var item in shortWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
