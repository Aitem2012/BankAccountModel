using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataStore
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<Account> accounts = new List<Account>();
        public static List<Transaction> transactions = new List<Transaction>();
        public static List<User> users = new List<User>();
    }
}
