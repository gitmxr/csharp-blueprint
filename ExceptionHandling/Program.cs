namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
             try
             {
                 string content = File.ReadAllText(@"C:\c#_Work\TestTxtFle.txt");
                 Console.WriteLine(content);
             }
             catch (FileNotFoundException ex)
             {
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("Name the file correctly as TestTxtFile.txt");
             }
             catch (DirectoryNotFoundException ex)
             {
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("Is this Directory exist");
             }
             catch (Exception ex)
             {
                 Console.WriteLine("There is a Problem");
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 Console.WriteLine("closing the Application...");
             }
             Console.ReadLine();

            

           /* Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine()!);

            if (age < 18)
            {
                throw new ArithmeticException("You are Under age!  you mus be at least 18y old!");
            }
            else 
            {
                Console.WriteLine("access Granted");
            }  
           */
        }
    }
}
