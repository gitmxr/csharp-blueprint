namespace FactorialByRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number:  " );
            int number = int.Parse( Console.ReadLine()!);
            Console.WriteLine("Factorial of {0} is : {1}", number, Factorial(number));

        }

        static int Factorial(int num)
        {

            if (num == 0) return 1;

            else return (num * Factorial(num - 1));
        }
    }
}
