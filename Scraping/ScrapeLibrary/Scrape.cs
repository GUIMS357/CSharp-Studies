using System;
using System.IO;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            // WebClient client = new WebClient();
            //return client.DownloadString(url);

            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);

            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            return content += "THAT'S ALL FOLKS";
            return content;
        }
    }
}
