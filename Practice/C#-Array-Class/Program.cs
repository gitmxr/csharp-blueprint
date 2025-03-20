using System.Collections;
using System.Collections.ObjectModel;

namespace Csharp_Array_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************************************************************************");

            // Declares a 1D array of integers
            int[] arr;

            // Allocating memory for the array
            arr = new int[] { 10, 20, 30, 40, 50, 60 };

            // Displaying the length of the array
            Console.WriteLine("Length of the array : " + arr.Length);
            Console.WriteLine("Is Aray has Fixed Sized : " + arr.IsFixedSize);

            int[] arr2 = new int[] { };
            Console.WriteLine("EmptyArray isFixedSize : "+arr2.IsFixedSize);

           // Arrays in C# are always fixed size, meaning they cannot change size after creation.

            ArrayList myList = new ArrayList() { 1, 2, 3 };
            Console.WriteLine("ArrayList IsFixedSize: " + myList.IsFixedSize); // Output: False

            Console.WriteLine("\n*****************************************************************************");

            // Display the rank (dimension) of the array
            Console.WriteLine("Rank of the array: " + arr.Rank);

            Console.WriteLine("\n*****************************************************************************");


            Console.WriteLine("IsReadOnly: " + arr.IsReadOnly); // Output: False

            // Array is not ReadOnly by default

            int[] numbers = { 1, 2, 3, 4, 5 };

            // Wrap array in ReadOnlyCollection
            ReadOnlyCollection<int> readOnlyNumbers = Array.AsReadOnly(numbers);

            Console.WriteLine("First Element: " + readOnlyNumbers[0]); // Output: 1

            // readOnlyNumbers[0] = 100; ❌ ERROR! Collection is read-only

            //method 2 (mjst in a class)

            //  private readonly int[] numbers = { 10, 20, 30 };

            //public void ModifyArray()
            //{
            //    numbers[0] = 100; // ✅ Allowed (modifying elements)
            //                      // numbers = new int[] { 1, 2, 3 }; ❌ ERROR! Cannot reassign a new array
            //}

            Console.WriteLine("\n*****************************************************************************");


            //Array methods

            //ReadOnlyMethod()
            ReadOnlyCollection<int> readOnlyNumbers2= Array.AsReadOnly(numbers);

            Console.WriteLine("Elements in read-only array:");
            foreach (int num in readOnlyNumbers2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // readOnlyNumbers[0] = 10; // ❌ ERROR: Cannot modify a read-only array

            Console.WriteLine("\n*****************************************************************************");


            //binarySearchMethod()

            int[] numbers_4_Index = { 10, 20, 30, 40, 50 };

            int index = Array.BinarySearch(numbers_4_Index, 30); // Searching for 30

            Console.WriteLine("Index of 30: " + index);

            int missingIndex = Array.BinarySearch(numbers_4_Index, 35); // Searching for 35 (not in array)
            Console.WriteLine("Index of 35 (not found): " + missingIndex);

            int indexof_10 = Array.BinarySearch(numbers_4_Index, 10);
            Console.WriteLine("index of 10: " + indexof_10);
            Console.WriteLine("\n*****************************************************************************");


            //Clear() Method 
            int[] numbers2 = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Before Clear:");
            PrintArray(numbers2);

            // Clearing elements from index 1 to 3
            Array.Clear(numbers2, 1, 3);

            Console.WriteLine("\nAfter Clear:");
            PrintArray(numbers2);
            Console.WriteLine("\n*****************************************************************************");


            // Clearing String Array

            string[] names = { "Alice", "Bob", "Charlie" };
            Array.Clear(names, 1, 1);

            foreach (var name in names)
                Console.WriteLine(name ?? "null"); // Using ?? to show "null" for cleared values
            Console.WriteLine("\n*****************************************************************************");


            //clone method 

            int[] originalArray = { 10, 20, 30, 40, 50 };
            int[] clonedArray = (int[])originalArray.Clone(); // Clone the array

            int[] OG_Array = new int[] { 22, 33, 44, 55 };
            int[] Clone_Array = (int[])OG_Array.Clone();

            Clone_Array[0] = 00;

            // Modify the cloned array
            clonedArray[0] = 99;

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Cloned Array: " + string.Join(", ", clonedArray)); 
            Console.WriteLine("OG_Array: " + string.Join(",", OG_Array ));
            Console.WriteLine("Cloned_Array: " + string.Join(", ",Clone_Array));
            Console.WriteLine("\n*****************************************************************************");


            Person[] orgArray = { new Person { Name = "Riaz" }, new Person {Name = "Ali" } };
            Person[] clnArray  = (Person[])orgArray.Clone();

            clnArray[0].Name = "RzEk"; // will effect the orgArray.Name bcz of reference type

            Console.WriteLine("Name from OrgArray : " + orgArray[0].Name);
            Console.WriteLine("Name from clnArray : " + clnArray[0].Name);
            Console.WriteLine("\n*****************************************************************************");



            Console.ReadKey();

        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        class Person
        {
            public string Name;
        }

    }
}
