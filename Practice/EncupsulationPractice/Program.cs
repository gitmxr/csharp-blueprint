namespace EncupsulationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank();
                //We cannot access the Amount Variable directly
                //bank.Amount = 50; //Compile Time Error
                //Console.WriteLine(bank.Amount); //Compile Time Error
                //Setting Positive Value

                bank.SetAmount(10);
                Console.WriteLine(bank.GetAmount());

                //Setting Negative Value
                bank.SetAmount(-150);
                Console.WriteLine(bank.GetAmount());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
    class Bank
    {
        private int amount;

        public void SetAmount(int amount)
        {
            if (amount < 0)
            {
                throw new Exception("please Enter Valid Amont!");

            }
            else
            {
                this.amount = amount;
            }
        }

        public int GetAmount()
        {
            return this.amount;
        }
    }
}
