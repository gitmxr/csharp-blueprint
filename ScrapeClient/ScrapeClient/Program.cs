using scrapeDataLibrary;

namespace ScrapeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Class1 cls = new Class1();
            cls.scrapeData("https://web.whatsapp.com/", @"C:\c#_Work\myfile");
        }
    }
}


