using System.Net;

namespace scrapeDataLibrary
{
    public class Class1
    {

        public string scrapeData(string url)
        {
            return getWebPage(url);
        }

        public string scrapeData(string url , string path)
        {
            string content  = getWebPage(url);

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
