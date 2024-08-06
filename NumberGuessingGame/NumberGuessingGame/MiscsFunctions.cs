using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    public class MiscsFunctions
    {
        public  bool MainMenue()
        {
            Console.WriteLine("1) : Print Numbers");
            Console.WriteLine("2) : Guessing Game ");
            Console.WriteLine("3) : Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                PrintNumber();
                return true;
            }
            else if (choice == 2)
            {
                GuessingGame();
                return true;
            }
            else if (choice == 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public  void PrintNumber()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.WriteLine("Enter the Number : ");
            int result = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= result)
            {
                Console.Write(i);
                Console.Write("-");
                i++;
            }
            Console.ReadLine();
        }
        public  void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myrandomNo = new Random();
            int randomNumber = myrandomNo.Next(1, 10);

            int guess = 0;
            bool WrongGuess = true;

            do
            {
                Console.WriteLine("Enter number between 1 and 10! ");
                String result = Console.ReadLine();
                guess++;

                if (result == randomNumber.ToString())
                {
                    WrongGuess = false;
                }
                else
                    Console.WriteLine("Wrong Guess!");
            }
            while (WrongGuess);
            Console.WriteLine("correct! It took U {0} guesses. ", guess);
            Console.ReadLine();
        }
    }
}
