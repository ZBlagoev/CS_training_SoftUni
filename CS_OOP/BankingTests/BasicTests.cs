using System;
using Xunit;
using BankyStuffLibrary;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            // test for negative balance
            var account = new BankAccount("Kendra", 10000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000, DateTime.Now, "attempt to overdraw")
                );
        }

        [Fact]
        public void Test2()
        {
            // test for the positive initial balance
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> new BankAccount("invalid", -55)
                );
            


        }
    }
}
