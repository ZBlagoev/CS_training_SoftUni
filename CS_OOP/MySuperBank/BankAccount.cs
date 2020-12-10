﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class BankAccount
    {
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

        private List<Transaction> allTransactions = new List<Transaction>();

        // constructor of a bank account
        public BankAccount(string name, decimal initialBalance)
        {
            /* for the purposes of the training the bank account number
             * will be a random starting seed of 1234567890 and each next
             * one will be incremented with 1 */
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}