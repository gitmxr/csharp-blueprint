using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Names Game");
            Console.ReadLine();

            Console.Write("Enter your firstName : ");
            string firtName = Console.ReadLine();

            Console.Write("Enter your LastName : ");
            string LasttName = Console.ReadLine();

            Console.Write("Enter your city : ");
            string City = Console.ReadLine();

            /* char[] firstNameArray = firtName.ToCharArray();
             Array.Reverse(firstNameArray);

             char[] lastNameArray = LasttName.ToCharArray();
             Array.Reverse(lastNameArray);

             char[] cityArray = City.ToCharArray();
             Array.Reverse(cityArray);
             string result = "";
             foreach (char item in firstNameArray)
             {
                 result += item;
             }
             result += " ";

             foreach(char item in lastNameArray)
             {
                result += item;
             }

             result += " ";

             foreach (char item in cityArray)
             {
                 result += item;
             }        
             Console.WriteLine(result);
             Console.ReadLine();*/

           /* string reversedFirstName = reversedString(firtName);
            string reversedLastName =  reversedString(LasttName);
            string reversedcity = reversedString(City);*/

           displayResults(
               reversedString(firtName),
               reversedString(LasttName),
               reversedString(City));
            Console.WriteLine();

            displayResults(
                reversedString(firtName)
                + " " +
                reversedString(LasttName)
                + " " +
                reversedString(City));
            Console.ReadLine() ;
        }
        private static string reversedString ( string message)
        {
            char[] messageArray  = message.ToCharArray();
            Array.Reverse(messageArray);
          return String.Concat(messageArray);

        }
        private static void displayResults(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
               reversedFirstName,
               reversedLastName,
               reversedCity));
        }
        private static void displayResults( string message)
        {
            Console.Write(message);
        }
    }
}
