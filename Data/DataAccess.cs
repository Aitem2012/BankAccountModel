using Data.Abstraction;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataAccess 
    {
        private static string _customerId;
        /// <summary>
        /// Register a customer to the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static bool RegisterCustomer(Customer customer)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                string statement = @"INSERT INTO [dbo].[CustomerDBL]
           ([CustomerID]
           ,[FirstName]
           ,[LastName])
     VALUES
           ('" + customer.CustomerId + "', '" + customer.FirstName + "', '" + customer.LastName + "')";

                DBConnection._cmd = new SqlCommand(statement, connection);

                DBConnection._cmd.ExecuteNonQuery();
                connection.Close();
            }
            
            return true;
        }

        /// <summary>
        /// Create the authentication for username and password
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static bool RegisterCustomerAuthentication(User user)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                string statement = @"INSERT INTO [dbo].[UserTBL]
           ([ID]
           ,[OwnersID]
           ,[Email]
           ,[PasswordHash]
           ,[PasswordSalt])
     VALUES
           ('" + user.CustomerId + "', '" + user.Customer.CustomerId + "','" + user.Email + "', '" + user.PasswordHash+"', '"+user.PasswordSalt+"')";

                DBConnection._cmd = new SqlCommand(statement, connection);

                DBConnection._cmd.ExecuteNonQuery();
                connection.Close();
            }
            
            return false;
        }

        /// <summary>
        /// Register the account of the user
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool RegisterAccount(Account account)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();

                string statement = @"INSERT INTO [dbo].[AccountDBL]
           ([AccountID]
           ,[OwnerID]
           ,[AccountNumber]
           ,[AccountType]
           ,[AccountBalance])
     VALUES
           ('" + account.Customer.CustomerId + "', '" + account.AccountId + "', '" + account.Customer.CustomerId + "', '" + account.AccType + "', '" + account.Balance + "')";

                DBConnection._cmd = new SqlCommand(statement, connection);

                DBConnection._cmd.ExecuteNonQuery();
                connection.Close();
            }


            return false;
        }

        /// <summary>
        /// Register transaction
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static bool RegisterTransaction(Transaction transaction)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                string statement = @"INSERT INTO [dbo].[TransactionDBL]
           ([TransactionID]
           ,[Amount]
           ,[AccountNumber]
           ,[TransactionDate]
           ,[TransactionType]
           ,[Note])
     VALUES
           ('" + transaction.TransactionId + "', '" + transaction.Amount + "', '" + transaction.Account.AccountNumber + "', '" + transaction.DateOfTransaction + "', " +
               "'" + transaction.TransactionId + "', '" + transaction.Note + "')";

                DBConnection._cmd = new SqlCommand(statement, connection);

                DBConnection._cmd.ExecuteNonQuery();
                connection.Close();
            }
            
            return false;
        }

        //Retrieve a customer by their ID
        public static Account RetrieveCustomerAccount(string email)
        {
            Account account;
            var customerId = GetCustomerID(email);
            var statement = @"SELECT [AccountID]
                              ,[OwnerID]
                              ,[AccountNumber]
                              ,[AccountType]
                              ,[AccountBalance]
                          FROM [dbo].[AccountDBL] WHERE OwnerID=@customerId";
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                DBConnection._cmd = new SqlCommand(statement, connection);
                DBConnection._cmd.Parameters.AddWithValue("@customerId", customerId);
                var readUserData = DBConnection._cmd.ExecuteReader();

                while (readUserData.Read())
                {
                    account = new Account
                    {
                        AccountNumber = readUserData["AccountNumber"].ToString(),
                        AccType = readUserData["AccountType"].ToString(),
                        Balance = Convert.ToDecimal(readUserData["AccountBalance"]),
                        //Account.= readUserData["AccountID"].ToString()
                        
                    };
                    return account;
                }
            }

            return null;
        }
        //get a user for authentication
        public static User RetrieveCustomerID(string email)
        {
            User user;
            var emailExist = UserExist(email);
            if (emailExist > 0)
            {
                var statement = @"SELECT [ID]
                                  ,[OwnersID]
                                  ,[Email]
                                  ,[PasswordHash]
                                  ,[PasswordSalt]
                              FROM [dbo].[UserTBL] where Email = @email";
                using (var connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    DBConnection._cmd = new SqlCommand(statement, connection);
                    DBConnection._cmd.Parameters.AddWithValue("@email", email);
                    var readUSerData = DBConnection._cmd.ExecuteReader();

                    while (readUSerData.Read())
                    {
                        user = new User
                        {
                            CustomerId = readUSerData["ID"].ToString(),
                            //Cus = readUSerData["OwnersID"].ToString(),
                            Email = readUSerData["Email"].ToString(),
                            PasswordHash = readUSerData["PasswordHash"].ToString(),
                            PasswordSalt = readUSerData["PasswordSalt"].ToString()
                        };
                        connection.Close();
                        _customerId = user.CustomerId;
                        return user;
                    }
                }
            }
            return null;
        }
        //get a customer through the email
        public static Customer RetrieveCustomerByEmail(string email)
        {
            Customer customer;
            var customerId = GetCustomerID(email);
            var statement = @"SELECT [CustomerID]
                              ,[FirstName]
                              ,[LastName]
                          FROM [dbo].[CustomerDBL] WHERE CustomerID=@customerId";

            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                DBConnection._cmd = new SqlCommand(statement, connection);
                DBConnection._cmd.Parameters.AddWithValue("@customerId", customerId);
                var readUserData = DBConnection._cmd.ExecuteReader();
                while (readUserData.Read())
                {
                    customer = new Customer
                    {
                        FirstName = readUserData["FirstName"].ToString(),
                        LastName = readUserData["LastName"].ToString()
                    };
                    return customer;
                }
            }
            return null;
        }
        public static string GetCustomerID(string email)
        {
            User user;
            var emailExist = UserExist(email);
            if (emailExist > 0)
            {
                var statement = @"SELECT [ID]
                                  ,[OwnersID]
                                  ,[Email]
                                  ,[PasswordHash]
                                  ,[PasswordSalt]
                              FROM [dbo].[UserTBL] where Email = @email";
                using (var connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    DBConnection._cmd = new SqlCommand(statement, connection);
                    DBConnection._cmd.Parameters.AddWithValue("@email", email);
                    var readUSerData = DBConnection._cmd.ExecuteReader();

                    while (readUSerData.Read())
                    {
                        user = new User
                        {
                            CustomerId = readUSerData["ID"].ToString(),
                            //Cus = readUSerData["OwnersID"].ToString(),
                            Email = readUSerData["Email"].ToString(),
                            PasswordHash = readUSerData["PasswordHash"].ToString(),
                            PasswordSalt = readUSerData["PasswordSalt"].ToString()
                        };
                        connection.Close();
                        
                        return user.CustomerId;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Check if a customer email exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static int UserExist(string email)
        {
            int customer;
            string statement = @"select count(*) from [dbo].[UserTBL] where Email = @email";
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                DBConnection._cmd = new SqlCommand(statement, connection);
                DBConnection._cmd.Parameters.AddWithValue("@email", email);
                int v = Convert.ToInt32(DBConnection._cmd.ExecuteScalar());
                customer = v;
                connection.Close();
            }
            return customer;
        }

        public static decimal Balance(string accountNumber)
        {
            decimal sum;
            var statement = @"SELECT sum(amount)
  FROM [dbo].[TransactionDBL] where AccountNumber =@accountNumber";

            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                DBConnection._cmd = new SqlCommand(statement, connection);
                DBConnection._cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                sum = Convert.ToDecimal(DBConnection._cmd.ExecuteScalar());
            }
            return sum;
        }

        public static Account GetAccountWithAccountNumber(string accountNumber)
        {
            Account account;
            
            var statement = @"SELECT [AccountID]
                              ,[OwnerID]
                              ,[AccountNumber]
                              ,[AccountType]
                              ,[AccountBalance]
                          FROM [dbo].[AccountDBL] WHERE AccountNumber=@accountNumber";
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                DBConnection._cmd = new SqlCommand(statement, connection);
                DBConnection._cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                var readUserData = DBConnection._cmd.ExecuteReader();

                while (readUserData.Read())
                {
                    account = new Account
                    {
                        AccountNumber = readUserData["AccountNumber"].ToString(),
                        AccType = readUserData["AccountType"].ToString(),
                        Balance = Convert.ToDecimal(readUserData["AccountBalance"]),
                        AccountId = readUserData["AccountID"].ToString()

                    };
                    return account;
                }
            }

            return null;
        }
        
        public static List<Transaction> StatementOfAccount(string accountNumber)
        {
            var transactions = new List<Transaction>();
            Transaction transaction;
            
            var statement = @"SELECT [TransactionID]
                              ,[Amount]
                              ,[AccountNumber]
                              ,[TransactionDate]
                              ,[TransactionType]
                              ,[Note]
                          FROM [dbo].[TransactionDBL] WHERE AccountNumber=@accountNumber";

            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                DBConnection._cmd = new SqlCommand(statement, connection);
                DBConnection._cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                var readUserData = DBConnection._cmd.ExecuteReader();
                while (readUserData.Read())
                {
                    transaction = new Transaction
                    {
                        Amount = Convert.ToDecimal(readUserData["Amount"]),
                        DateOfTransaction =Convert.ToDateTime(readUserData["TransactionDate"]),
                        Note = readUserData["Note"].ToString()
                    };
                    transactions.Add(transaction);
                }
            }
                return transactions;
        }

        public static DataSet StatementOfAccounts(string accountNumber)
        {

            return null;
        }
    }
}
