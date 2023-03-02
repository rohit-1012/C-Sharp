using System;
using System.Net;

namespace myCodeLibrary
{
    public class Scrape
    {
        public string scrapeWebPage(string url)
        {
            return getWebPage(url);
        }

        public string scrapeWebPage(string url, string filePath)
        {
            string reply = getWebPage(url);

            File.WriteAllText(filePath, reply);
            return reply;
        }

        private string getWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

    }
}