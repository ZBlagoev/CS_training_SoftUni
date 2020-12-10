using System;
using Humanizer;

namespace BankyStuffLibrary
{
    public class Transaction
    {
        /***********************************************/
        // properties of the transactions class
        public decimal Amount { get; }
        public string AmountForHumans { get
            {
                return ((int)Amount).ToWords();
            }
        }
        public DateTime Date { get; }
        public string Notes { get; }

        /***********************************************/
        // constructor of a transaction
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;

            this.Date = date;

            this.Notes = note;
        }
    }
}
