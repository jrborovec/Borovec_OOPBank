namespace Borovec_OOPBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank Bank = new Bank(1000);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("----- Main Menu -----");
                Console.WriteLine("1. Make a Deposit");
                Console.WriteLine("2. Make a Withdrawal");
                Console.WriteLine("3. Check Current Balance");
                Console.WriteLine("0. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: Console.WriteLine("How much would you like to deposit?");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        Bank.Deposit(deposit);
                        break;
                    case 2: Console.WriteLine("How much would you like to withdraw?");
                        int withdrawal = Convert.ToInt32(Console.ReadLine());
                        Bank.Withdrawal(withdrawal);
                        break;
                    case 3: Bank.CheckBalance();
                        break;
                    case 0: Console.WriteLine("Exiting...");
                        isRunning = false;
                        break;
                    default: Console.WriteLine("Please enter a valid selection.");
                        break;



                }
            }
        }
    }
}
