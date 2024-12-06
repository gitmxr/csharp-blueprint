using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace WritingDataIntoTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string path = @"c:\c#_Work\dull.txt";

              if (!File.Exists(path))
              {
                  string createText = "Write this Data into the Text FIle.." ;
                  System.IO.File.WriteAllText(path, createText);
              }
            */

            // method to delete File

            // File.Delete(path );

            // This is Second Method
            /*
            string Text = "This is a second method of writting data into File ";
            File.WriteAllText(@"C:\c#_Work\SecondTxtFile`.txt",Text);
            */

            // Add Extra Text to Existing File

            //string appendText = "\nThis is Extra Text";
            //File.AppendAllText(@"C:\c#_Work\SecondTxtFile.txt", appendText);


            // Open the file to read from.

            // string readText = File.ReadAllText(@"C:\c#_Work\SecondTxtFile.txt");
            //Console.WriteLine(readText);

            // to downlaod web html 


            //WebClient client = new WebClient();   
            //string reply = client.DownloadString("https://www.w3schools.com/python/");

            //Console.WriteLine(reply);

            //File.WriteAllText(@"C:\c#_Work\msdnWebHtml.txt", reply);

            //Console.ReadLine();

            
        }
    }
}
