namespace RecursionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* int x = 3;
            fun(x);
            Console.ReadKey();*/



            int x = 3;
            fun2(x);
            Console.ReadKey();
        }
        static void fun(int n)
         {
             if (n > 0)
             {
                 Console.Write($"{n} ");
                        fun(n - 1);

             }
         }

        static void fun2(int n)
        {
            if (n > 0)
            {
                fun2(n - 1);
                Console.Write($"{n} ");
            }
        }

    }
}
