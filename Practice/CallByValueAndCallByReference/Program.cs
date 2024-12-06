namespace CallByValueAndCallByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CallByValue


            /*
             int a = 15;
             int b = a;
             b = 30;
             Console.WriteLine(a);
             Console.ReadKey();
            */


            /*
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";
            Employee Emp2 = Emp1;
            Emp1.Name = "Smith";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.WriteLine($"Emp2 Name = {Emp2.Name}");
            Console.ReadKey();
            */

            /*
              int a = 15;
              //UpdateValue(ref a);
              ref int b = ref a;
              b = 34;
              Console.WriteLine(a);
              Console.ReadKey();
            */

            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            UpdateName(ref Emp1);
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.ReadKey();

        }

        public static void UpdateName(ref Employee Emp2)
        {
            Emp2.Name = "riaz";
        }
        static void UpdateValue(ref int b)
        {
            b = 30;
        }
    }

    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }
}
