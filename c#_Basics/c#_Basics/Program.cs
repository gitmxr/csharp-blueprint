using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter First Number : ");
            int n1 = int.Parse( Console.ReadLine());
             Console.WriteLine("Enter the Second Number");
             int n2 = int.Parse(Console.ReadLine());
             int sum = n1 + n2;
             int diff = n1 - n2;
             Console.WriteLine("Sum is {0} and difference is : {1}",sum,diff);
             Console.ReadLine(); */

            // if else program 


             Console.WriteLine("Enter your Score");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine('A');
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D");
            }
            else if (score < 60)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Enter Valid Score");
            }
            Console.ReadLine(); 


        }
    }
}
