using System.Security.Cryptography.X509Certificates;

namespace DelegatesPractice2
{
    internal class Program
    {
        public delegate void myDelegate(string msg);
        public static void PrintGreetings(string msg) { Console.WriteLine("Message:" + msg);}
        public static void PrintAnnoucements(string msg) { Console.WriteLine("Annoucement: " + msg);}

        //Callback with a Delegate, Delegates are often used for callbacks, where you pass a method to another method.
        public delegate void Callback(string result);
        public static void ProcessData(string input, Callback callback)
        {
            string result = input.ToUpper();
            callback(result);// Call the delegate with the result
        }

        public static void PrintResult(string result) { Console.WriteLine("Processed Result: " + result); }
        static void Main(string[] args)
        {
            //delegates With Single Method

            //myDelegate del = PrintGreetings;
            //del("Hello! Good Morning Riaz!");


            //delegates With Multiple Methods 

            //myDelegate del = PrintGreetings;
            //del("Hello! Good Morning Riaz!");     

            //del = PrintAnnoucements;
            //del("Hey! Tommorow is Holiday");


            //Multicast delegates

            //myDelegate del = PrintGreetings;            
            //del += PrintAnnoucements;
            //del("Hey! This is multicast Delegate.");


            //Delegates with anynomous method 

            //myDelegate del = delegate (string msg)
            //{ Console.WriteLine("Annonomous : "+msg); };
            //del("This is Annonomous Method!");

            //lambdas with delegates 

            //myDelegate del = (msg) => Console.WriteLine("Lambda : "+msg);
            //del("This is lambda Method");

            //callback with delegates
            ProcessData("hello! riaz", PrintResult); // Pass the PrintResult method as a callback
            Console.WriteLine("**********************");

            // built -in generic delegates

            // 1.Func
            Func<string, string, string> ConCetinate = (firstName, lastName) =>
            {
                return firstName + " " + lastName;
            };
            string fullName =  ConCetinate("Md", "Riaz");
            Console.WriteLine(fullName);
            Console.WriteLine("**********************");


            // 2.Action

            Action<string, int, string> BilliMembers = (Name, Age, Weight) =>
            {
                Console.WriteLine("NAME : " + Name + ", Age : " + Age + ", Weight : " + Weight);
            };
            BilliMembers("Riaz", 22, "63kg");
            BilliMembers("Hassan", 22, "68kg");
            Console.WriteLine("**********************");


            // 3.Predicate 

            Predicate<int> IsGreater= (Num) =>
            {
                return Num > 10;
            };
            Console.WriteLine(IsGreater(5));
            Console.WriteLine(IsGreater(55));
            Console.WriteLine("**********************");


            // Predicate example 2. Use predicate to find all numbers > 10
            
            List<int> numbers = new List<int> { 1, 5, 10, 15, 20 };

            //<int> filter = numbers.FindAll(IsGreater);
            List<int> filter = numbers.FindAll(num => num > 10);

            Console.WriteLine(string.Join(", ", filter)); 
            Console.WriteLine("**********************");
           

            // Predicate to filter numbers greater than 10
            Predicate<int> isGreaterThanTen = num => num > 10;

            // Func to double a number
            Func<int, int> doubleNumber = num => num * 2;

            // Action to print a number
            Action<int> printNumber = num => Console.WriteLine($"Number: {num}");

            // Filter numbers
            List<int> filteredNumbers = numbers.FindAll(isGreaterThanTen);

            // Process and print the filtered numbers
            foreach (int number in filteredNumbers)
            {
                int doubled = doubleNumber(number);  // Double the number
                printNumber(doubled);                // Print the doubled number
            }
            Console.ReadLine();


        }
    }
}
