using ScrapeDataLibrary2;

namespace sccrapeData2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           scrapeData scrapeData = new scrapeData();
            scrapeData.scrape_Data("http:/msdn.mircosoft.com");
        }
    }
}

