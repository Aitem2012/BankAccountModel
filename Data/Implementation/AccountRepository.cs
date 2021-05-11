using Data.Abstraction;
using Data.Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class AccountRepository : IAccountRepository
    {

        private readonly BankWorldDbContext _ctx;

        public AccountRepository()
        {
            _ctx = new BankWorldDbContext();
        }

        /// <summary>
        /// Create an account for a customer
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="accType"></param>
        /// <returns></returns>
        public Account CreateAccount(string ownerId, string accType)
        {
            Account account;
            if (accType == "Savings")
            {
                account = new Account
                {
                    CustomerId = ownerId,
                    AccType = "Savings",
                    MinimumBalance = 1000.00m
                };
                //DataStore.accounts.Add(account);
                _ctx.Accounts.Add(account);
                _ctx.SaveChanges();
               // DataAccess.RegisterAccount(account);
                return account;
            }
            else if (accType == "Current")
            {
                account = new CurrentAccount
                {
                    CustomerId = ownerId,
                    AccType = "Current",
                    MinimumBalance = 0.00m
                };
                //DataStore.accounts.Add(account);
                _ctx.Accounts.Add(account);
                var s = _ctx.SaveChanges();
                //DataAccess.RegisterAccount(account);
                return account;
            }
            return null;
        }
        /// <summary>
        /// Carry out a deposit transaction
        /// </summary>
        /// <param name="account"></param>
        /// <param name="amount"></param>
        /// <param name="note"></param>
        public void Deposit(string accountId, decimal amount, string note)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Invalid Amount");
            }
            var deposit = new Transaction
            {

                Amount = amount,
                Note = note,
                AccountId = accountId
            };
            //transactions.Add(deposit);
            //DataAccess.RegisterTransaction(deposit);
            _ctx.Transactions.Add(deposit);
            _ctx.SaveChanges();

        }

        /// <summary>
        /// Retrieve the balance for a given account number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public decimal GetBalance(string accountNumber)
        {
            var balance = _ctx.Transactions.Where(x => x.AccountId == accountNumber).Select(x => x.Amount).ToList().Sum();
            //return DataAccess.Balance(accountNumber);
            return balance;
        }

        /// <summary>
        /// Transfer funds between two accounts
        /// </summary>
        /// <param name="sourceAccount"></param>
        /// <param name="destinationAccount"></param>
        /// <param name="amount"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public string[] Transfer(string sourceAccount, string destinationAccount, decimal amount, string note)
        {
            var res = new string[2];
            var sender = _ctx.Accounts.FirstOrDefault(x => x.AccountNumber == sourceAccount);
            var receiver = _ctx.Accounts.FirstOrDefault(x => x.AccountNumber == destinationAccount);

            //var senderaccount = DataStore.accounts.Find(a => a.AccountNumber == sourceAccount);
            //var receiverAccount = DataStore.accounts.Find(a => a.AccountNumber == destinationAccount);
            if (sender.AccountNumber == receiver.AccountNumber)
            {
                res[0] = "Transfer within the same account is not allowed";
            }
            else
            {

                var bal = GetBalance(sender.AccountId);
                if ((bal - amount) < sender.MinimumBalance)
                {
                    res[0] = "failed";
                    res[1] = "INSUFFICIENT FUNDS: MINIMUM BALANCE EXCCEDED!";
                    return res;
                }
                else
                {
                    Withdraw(sender.AccountId, amount, "Transfer");
                    Deposit(receiver.AccountId, amount, "Credit");

                    res[0] = "Success";
                }

            }

            return res;
        }

        /// <summary>
        /// Make a withdrawal from an account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="amount"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public string[] Withdraw(string accountId, decimal amount, string note)
        {
            var acc = _ctx.Accounts.FirstOrDefault(x => x.AccountId == accountId);
            var bal = GetBalance(accountId);

            //var account1 = DataAccess.GetAccountWithAccountNumber(account);
            //var balance = GetBalance(account);
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Withdrawal amount is invalid");
            }
            var res = new string[2];
            var ss = bal - amount;
            if (ss < acc.MinimumBalance)
            {
                res[0] = "Error";
                res[1] = "Insufficient Fund for the transaction";
            }
            else
            {
                Transaction transaction = new Transaction
                {

                    Amount = -amount,
                    Note = note,
                    AccountId = accountId
                };
                //transactions.Add(transaction);
                //DataAccess.RegisterTransaction(transaction);
                _ctx.Transactions.Add(transaction);
                _ctx.SaveChanges();
                res[0] = "Successful";
                res[1] = "Transaction Completed";
            }

            return res;
        }

        /// <summary>
        /// Get the statement of account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public List<Transaction> GetTransactionByAccountNumber(string accountNumber)
        {
            var res = _ctx.Transactions.Where(x => x.Account.AccountNumber == accountNumber).Select(x => x).ToList();
            //return DataAccess.StatementOfAccount(accountNumber);
            return res;
        }

        public Account GetAccountDetails(string customerId)
        {

            var accounts = _ctx.Accounts.Include("Customer").FirstOrDefault(x => x.CustomerId == customerId);
            //return DataAccess.RetrieveCustomerAccount(accountNumber);

            return accounts;
        }

        
    }
}
