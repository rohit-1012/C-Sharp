using myCodeLibrary;

namespace myClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.scrapeWebPage("https://www.shahandanchor.com/home/");
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}