using Core.Interfaces;
using Data.Abstraction;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public Account CreateAccount(string ownerId, string accType)
        {
            return _accountRepository.CreateAccount(ownerId, accType);
        }
        public void Deposit(string account, decimal amount, string note)
        {
            _accountRepository.Deposit(account, amount, note);
        }

        public decimal GetBalance(string accountNumber)
        {
            return _accountRepository.GetBalance(accountNumber);
        }

        public string[] Transfer(string sourceAccount, string destinationAccount, decimal amount, string note)
        {
            return _accountRepository.Transfer(sourceAccount, destinationAccount, amount, note);
        }

        public string[] Withdraw(string account, decimal amount, string note)
        {
            return _accountRepository.Withdraw(account, amount, note);
        }
        public List<Transaction> GetTransactionByAccountNumber(string accountNumber)
        {
            return _accountRepository.GetTransactionByAccountNumber(accountNumber);
        }

        public Account GetAccountDetails(string accountNumber)
        {
            return _accountRepository.GetAccountDetails(accountNumber);
        }
    }
}
