using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an account
            var account = new BankAccount("Zhelyazko Blagoev", 500);

            // print account info
            Console.WriteLine();
            Console.WriteLine($"Account {account.Number} was created for " +
                $"{account.Owner} with {account.Balance} dollars.");

            // make some transactions
            account.MakeWithdrawal(119.95m, DateTime.Now, "Hammock");
            account.MakeWithdrawal(59.99m, DateTime.Now, "Nintendo Game");
            account.MakeDeposit(200, DateTime.Now, "Savings");
            account.MakeWithdrawal(199.95m, DateTime.Now, "Microwave");
            account.MakeWithdrawal(3.95m, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5.99m, DateTime.Now, "Breakfast");
            account.MakeWithdrawal(1.95m, DateTime.Now, "Water");
            account.MakeDeposit(9.99m, DateTime.Now, "Couch Money");

            // print ledger
            Console.WriteLine();
            Console.WriteLine("Account ledger:");
            Console.WriteLine(account.GetAccountHistory());

            Console.WriteLine();
            Console.WriteLine($"Account balance: {account.Balance} dollars");
        }
    }
}
