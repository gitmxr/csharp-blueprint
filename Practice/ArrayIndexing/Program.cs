namespace ArrayIndexing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNo = new int[100];
            Random random = new Random();
            for (int i = 0; i < randomNo.Length; i++) {
                randomNo[i] = random.Next(60,100);
            }
             
            for(int j=0; j<randomNo.Length; j++)
            {
                if (randomNo[j] == 67)
                {
                    Console.WriteLine("index of 67 is found at: " + j);
                }  
            }
           
            Console.ReadLine();
        }
    }
}
