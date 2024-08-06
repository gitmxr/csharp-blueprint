using System.Net;

namespace ScrapeDataLibrary2
{
    public class scrapeData
    {
        public string scrape_Data(string url)
        {
            return getWebPage(url);
        }

        public string scrape_Data(string url, string path)
        {
            string content = getWebPage(url);

            File.WriteAllText(path, content);

            return content;
        }

        public string getWebPage(string url)
        {

            WebClient client = new WebClient();
            string result = client.DownloadString(url);
            return result;
        }
    }
}
