namespace AbstractionUsinInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing Meezan Bank");
            Bank meezan = BankFactory.GetBankObj("Meezan");
            meezan.ValidateCard();
            meezan.WithdrawMoney();
            meezan.CheckBalanace();
            meezan.BankTransfer();
            meezan.MiniStatement();
        }
    }
    public interface Bank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }
    public class BankFactory
    {
        public  static Bank GetBankObj(string bankType)
        {
            Bank bankobj = null;

            if (bankType == "Meezan")
            {
                bankobj = new Meezan();
            }
            else if (bankType == "MCB")
            {
                bankobj = new MCB();
            }
            return bankobj;
        }

        public class Meezan : Bank
        {
            public void ValidateCard()
            {
                Console.WriteLine("Meezan Bank Vlaidate Card");
            }
            public void WithdrawMoney()
            {
                Console.WriteLine("Meezan Bank WidrawMoney");
            }
            public void CheckBalanace() 
            { 
                Console.WriteLine("Meezan Bank CheckBalance");
            }
            public void BankTransfer() 
            {
                Console.WriteLine("Meezan Bank BankTransfer ");
            }
            public void MiniStatement() 
            { 
                Console.WriteLine("Meezan MiniTransfer");
            }
        }
        public class MCB : Bank
        {
            public void ValidateCard()
            {
                Console.WriteLine("MCB Bank Vlaidate Card");
            }
            public void WithdrawMoney()
            {
                Console.WriteLine("MCB Bank WidrawMoney");
            }
            public void CheckBalanace()
            {
                Console.WriteLine("MCB Bank CheckBalance");
            }
            public void BankTransfer()
            {
                Console.WriteLine("MCB Bank BankTransfer ");
            }
            public void MiniStatement()
            {
                Console.WriteLine("MCB MiniTransfer");
            }
        }
    }
}
