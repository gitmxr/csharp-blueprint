namespace ArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Ararys Practice ***************");
            Console.WriteLine("");
            Console.WriteLine("");

            // Defining array with size, but not assigns values
            int[] intArr = new int[10];

            //Defining array with size and assigning the values at the same time
            int[] intArr2 = new int[3] { 1, 2, 3 };

            //The value of the array is directly initialized without taking its size
            int[] intArr3 = { 2, 4, 6 };

            //Accessing array elements using different loops 

            int[] numbers = new int[5];

            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;
            numbers[3] = 20;
            numbers[4] = 25;

            Console.WriteLine("**************************************");
            Console.WriteLine("Access Array elements through for loop");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("**************************************");
            Console.WriteLine("Access Aray elements through forech loop");

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("**************************************");
            Console.WriteLine("Access Array elements through while loop");

            int j = 0;
            while (j < numbers.Length) 
            { 
                Console.Write(numbers[j] + " ");
                j++;
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("**************************************");
            Console.WriteLine("Access Array elements through do while loop");

            int k = 0;
            do 
            {
                Console.Write(numbers[k] + " ");
                k++;
            }
            while (k < numbers.Length);

            Console.WriteLine("**************************************");
            Console.WriteLine("Access Array elements through  forech loop");

            string[] names = new string[numbers.Length];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "Name" + i;
            }

            foreach (string i in names)
            {
                Console.WriteLine(i + " ");
            }


            Console.WriteLine("**************************************");
            Console.WriteLine(  "MULTI-DIMENTIONAL ARRAY");

            int[,] recArray = new int[2, 3]
            {
            {2,3,4},
            {3,4,5 }
            };
            Console.Write("RecArray :{ ");
            for (int i = 0;i < recArray.GetLength(0);i++)
            {
                Console.Write("{");
                for (int m = 0; m < recArray.GetLength(1); m++)
                {
                    Console.Write(recArray[i, m]+ " ");
                }
                Console.Write("}");
            }
            Console.WriteLine("};");

            Console.WriteLine("**************************************");
            Console.WriteLine("3D ARRAY");

            int[,,] _3DayArray = new int[2, 2, 3]
            {
              { 

                    {1,2,3 },{4,5,6 } 

              },//layer 1

              {

                {6,7,8 },{ 9,10,11}

              }, //layer 2
            };


            for (int i = 0; i < _3DayArray.GetLength(0); i++)
            {
                for (int m = 0; m < _3DayArray.GetLength(1); m++)
                {
                    for (int n = 0; n < _3DayArray.GetLength(2); n++)
                    {
                        Console.Write(_3DayArray[i, m, n] + " "); // Print element
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
