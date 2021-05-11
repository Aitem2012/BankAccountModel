using Utilities;
using System;

namespace BankWorld.UI
{
    class Program
    {
        static void Main(string[] args)
         {
            //GlobalConfig.AddInstance();
            //var customerService = GlobalConfig.customerService;
            //var password = Utilities.GenerateHash("1234");
            //var my = customerService.RegisterCustomer(new Lib.Model.Customer()
            //{
            //    FirstName = "Ibrahim",
            //    LastName = "Temitope",
            //    EmailAddress = "Aitem@aitem.com",
            //    PasswordHash = password[0],
            //    PasswordSalt = password[1]

            //}) ;

            //var user = GlobalConfig.authService;
            //var myUser = user.CreateUser(my);

            //Console.WriteLine(user.UserExist(my.EmailAddress));

            //var accountService = GlobalConfig.accountService;
            //var myAcc = accountService.CreateAccount(my.CustomerId, "Savings");
            //Console.WriteLine($"Customer Name: {my.FirstName} {my.LastName} " +
            //   $"Account Number: {myAcc.AccountNumber}");

            //accountService.Deposit(myAcc.AccountNumber, 5000, "depost");

            //Console.WriteLine(accountService.GetBalance(myAcc.AccountNumber));
            //accountService.Withdraw(myAcc.AccountNumber, 200, "withdrawal");
            //Console.WriteLine(accountService.GetBalance(myAcc.AccountNumber));

            //var trans = accountService.GetTransactionByAccountNumber(myAcc.AccountNumber);

            //Console.WriteLine("Amount \t Date \t Note");
            //foreach (var item in trans)
            //{
            //    Console.WriteLine($"{item.Amount} \t {item.DateOfTransaction} \t {item.Note}");
            //}

            //var cus = customerService.GetCustomerByEmail("Aitem@aitem.com");
            //Console.WriteLine(cus.CustomerId);

        }
    }
}
