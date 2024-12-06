namespace PropertiesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person  person = new Person();
            Console.WriteLine("Name is : {0}", person.Name = "Hassan");
            Console.WriteLine("Name is : {0}", person.age = 25);
        }

        class Person
        {
           // Actual Method
            private string name;
            public String Name
            {
                get { return name; }
                set { name = value; }
            }

            // Short Mthod 

            public int age { get; set;}

    }

}
}
