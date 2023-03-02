using System.Net;

namespace fundamentalsAssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string textFile = "This is a simple text file that contains text entered into a string variable setup in a C# code block that will be converted into a text file by a C# class library referenced using a C# class command!";
            */
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://learn.microsoft.com/en-us/");
            File.WriteAllText(@"D:\Rohit Stuff\Rohit Stuff\C# Practice\testTextFile.txt", reply);

            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
} 