using Data.Abstraction;
using Data.Data;
using Data.Implementation;
using Data.Implementations;
using Microsoft.EntityFrameworkCore;
using Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;


namespace Data.Test
{
    public class AccountDataTestpu
    {
        [Fact]
        public void BalanceWorks()
        {
            // Arrange 
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };

            var account = new Account
            {
                AccountId = Guid.NewGuid().ToString(),
                Customer = customer,
                MinimumBalance = 1000.00m,
                AccType = "Savings",
                AccountNumber = "1234567890",
                Balance = 5000
            };

            var acc = new AccountRepository();

            acc.Deposit(account.AccountId, 7000, "insurance");
            acc.Deposit(account.AccountId, 3000, "");
            var expected = acc.GetBalance(account.AccountId);

            // Act
            var actual = 10000;

            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void BalanceNotWorks()
        {
            // Arrange 
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };

            var account = new Account
            {
                AccountId = Guid.NewGuid().ToString(),
                Customer = customer,
                MinimumBalance = 1000.00m,
                AccType = "Savings",
                AccountNumber = "1234567890",
                Balance = 5000
            };

            var acc = new AccountRepository();

            acc.Deposit(account.AccountId, 7000, "insurance");
            
            var expected = acc.GetBalance(account.AccountId);

            // Act
            var actual = 10000;

            // Assert
            Assert.NotEqual(actual, expected);
        }

        [Fact]
        public void WithdrawalWorks()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");

            acc.Deposit(account.AccountId, 7000, "insurance");
            var expected = acc.Withdraw(account.AccountId, 2000, "");
            // Act
            var actual = "Successful";

            // Assert
            Assert.Equal(expected[0], actual);
        }

        [Fact]
        public void WithdrawalFails()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");

            acc.Deposit(account.AccountId, 7000, "insurance");
            var expected = acc.Withdraw(account.AccountId, 9000, "");
            // Act
            var actual = "Error";

            Assert.Equal(expected[0], actual);
        }

        [Fact]
        public void WithdrawalThrowsException()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");

            acc.Deposit(account.AccountId, 7000, "insurance");
            var expected = acc.Withdraw(account.AccountId, 9000, "");
            // Act


            Assert.Throws<ArgumentOutOfRangeException>(()=> acc.Withdraw(account.AccountId, -900, ""));
        }

        [Fact]
        public void GetAccountDetailsWorks()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var actual = acc.CreateAccount(customer.CustomerId, "Savings");

            // Act
            var expected = acc.GetAccountDetails(customer.CustomerId);
            // Assert

            Assert.Equal(expected.AccountNumber, actual.AccountNumber);

        }

        [Fact]
        public void GetAccountDetailsWorksNotWork()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            //var actual = acc.CreateAccount(customer.CustomerId, "Savings");

            // Act
            var expected = acc.GetAccountDetails(customer.CustomerId);
            // Assert

            Assert.Null(expected);

        }

        [Fact]
        public void DepositWorks()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");

            acc.Deposit(account.AccountId, 7000, "insurance");
            var expected = acc.GetBalance(account.AccountId);
            // Act
            var actual = 7000;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DepositThrowsException()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");

            

            Assert.Throws<InvalidOperationException>(()=> acc.Deposit(account.AccountId, -7000, "insurance"));
        }

        [Fact]
        public void GetListOfTransactionsWorks()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");

            acc.Deposit(account.AccountId, 7000, "insurance");
            acc.Withdraw(account.AccountId, 2000, "");

            var expected = acc.GetTransactionByAccountNumber(account.AccountNumber).Count;
            // Act
            var actual = 2;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TransferWorks()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var customer1 = new Customer
            {
                FirstName = "Yusuf",
                LastName = "Joseph",
                CustomerId = Guid.NewGuid().ToString()
            };

            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");
            var account1 = acc.CreateAccount(customer1.CustomerId, "Current");
            acc.Deposit(account.AccountId, 7000, "insurance");

            var expected = acc.Transfer(account.AccountNumber, account1.AccountNumber, 1000, "");


            // Act
            var actual = "Success";

            // Assert
            Assert.Equal(expected[0], actual);

        }

        [Fact]
        public void TransferFails()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Kabiru",
                LastName = "solomon",
                CustomerId = Guid.NewGuid().ToString()
            };
            var customer1 = new Customer
            {
                FirstName = "Yusuf",
                LastName = "Joseph",
                CustomerId = Guid.NewGuid().ToString()
            };

            var acc = new AccountRepository();
            var account = acc.CreateAccount(customer.CustomerId, "Savings");
            var account1 = acc.CreateAccount(customer1.CustomerId, "Current");
            acc.Deposit(account.AccountId, 7000, "insurance");

            var expected = acc.Transfer(account.AccountNumber, account.AccountNumber, 1000, "");


            // Act
            var actual = "Transfer within the same account is not allowed";

            // Assert
            Assert.Equal(expected[0], actual);

        }
    }
}
