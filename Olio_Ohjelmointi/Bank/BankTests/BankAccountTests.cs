using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            
            //act 
            account.Debit(debitAmount);

            //assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WithNegativeValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 100;
            double debitAmount = 205;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //act
            try
            {
                account.Debit(debitAmount);
            }

            catch(ArgumentOutOfRangeException)
            {
                return;
            }

            //Array
            Assert.Fail();
        }

        [TestMethod]
        public void Debit_TooGreatValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 104;
            double debitAmount = 110;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //act
            try
            {
                account.Debit(debitAmount);
            }

            catch (ArgumentOutOfRangeException)
            {
                return;
            }

            //Array
            Assert.Fail("No expection thrown too great amount");
        }
    }
}
