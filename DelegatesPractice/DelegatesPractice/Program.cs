namespace DelegatesPractice
{
    internal class Program
    {
        public delegate void MyDelegate(string msg);

        public delegate int MyDelegate2(int num1, int num2);
        static void Main(string[] args)
        {
            /*
             * Action (upto 16 parameters, return type: void)
             * 
             * Func   (has return type)
             * 
             * Predicate (returns bool)
             */


            Func<int, int, int> func = (a, b) => a + b;
            Console.WriteLine(func(1, 2)); ;

            Predicate<int> IsPositive = (num) =>
            {
                if (num > 0)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(IsPositive(-23));
        }

        

        private static void ActionDelegatePractice()
        {
            Action<string, int> action = (msg, age) =>
            {
                Console.WriteLine("Hi Riaz: " + msg + " Your age: " + age);
            };

            action("Welcome", 23);
        }

        private static void CallingDelegates()
        {
            MyDelegate del1 = new MyDelegate(greet);

            // del1 += farewell;
            MyDelegate del2 = new MyDelegate(farewell);

            del1("Hi Riaz");
            del2("Bye Riaz");

            MyDelegate2 del3 = new MyDelegate2(add);

            Console.WriteLine(del3(2, 4));
        }

        public static void greet(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void farewell(string msg)
        {
            Console.WriteLine(msg);
        }

        public static int add(int a, int b)
        {
            return a + b;
        }
       
    }
}
