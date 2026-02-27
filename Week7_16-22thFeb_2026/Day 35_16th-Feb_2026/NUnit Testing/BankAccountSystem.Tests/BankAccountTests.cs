using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Tests
{
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(100);
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            // Act
            account.Deposit(50);

            // Assert
            Assert.That(account.Balance, Is.EqualTo(150));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            // Act
            account.Withdraw(40);

            // Assert
            Assert.That(account.Balance, Is.EqualTo(60));
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
        }
    }

}
