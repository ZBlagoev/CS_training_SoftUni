using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class BankAccount
    {
        /***********************************************/
        // properties of the BankAccount class
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            } 
        }

        private static int accountNumberSeed = 1234567890;
        // list of all transactions
        private List<Transaction> allTransactions = new List<Transaction>();

        /***********************************************/
        // constructor of a bank account
        public BankAccount(string name, decimal initialBalance)
        {
            /* for the purposes of the training the bank account number
             * will be a random starting seed of 1234567890 and each next
             * one will be incremented with 1 */
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

        }

        /***********************************************/
        // method for making deposits
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                    "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        /***********************************************/
        // method for making withdrawals
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                    "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        /***********************************************/
        // method for getting the report of the account
        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            // header
            report.AppendLine("Date\t\tAmount\tNote");

            // report rows
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
