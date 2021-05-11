using Data.Abstraction;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction AddTransaction(decimal amount, string note)
        {
            Transaction transaction = new Transaction
            {

                Amount = amount,
                Note = note
            };
            //DataStore.transactions.Add(transaction);
            DataAccess.RegisterTransaction(transaction);
            return transaction;
        }

    }
}
