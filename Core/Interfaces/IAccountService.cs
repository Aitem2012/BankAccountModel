using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAccountService
    {
        Account CreateAccount(string ownerId, string accType);
        void Deposit(string account, decimal amount, string note);
        string[] Withdraw(string account, decimal amount, string note);
        string[] Transfer(string sourceAccount, string destinationAccount, decimal amount, string note);
        decimal GetBalance(string accountNumber);
        List<Transaction> GetTransactionByAccountNumber(string accountNumber);
        Account GetAccountDetails(string accountNumber);
    }
}
