using scrapeLibrary;

namespace scrapeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.scrapeWebPage("https://www.shahandanchor.com/home/", @"D:\Rohit Stuff\Rohit Stuff\C# Practice\newtestTextFile.txt");
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}