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

            // print ledger
            Console.WriteLine();
            Console.WriteLine("Account ledger:");
            Console.WriteLine(account.GetAccountHistory());

            Console.WriteLine();
            Console.WriteLine($"Account balance: {account.Balance} dollars");
        }
    }
}
