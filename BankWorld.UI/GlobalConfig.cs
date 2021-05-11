using Core.Implementations;
using Core.Interfaces;
using Data.Abstraction;
using Data.Data;
using Data.Implementation;
using Data.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankWorld.UI
{
    public static class GlobalConfig
    {
        public static ICustomerService customerService { get; set; }
        public static IAccountService accountService { get; set; }
        public static IAuthService authService { get; set; }
        
        /// <summary>
        /// Add and instance of the global config
        /// </summary>
        public static void AddInstance()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            customerService = new CustomerService(customerRepository);

            IAccountRepository accountRepository = new AccountRepository();
            accountService = new AccountService(accountRepository);

            IAuthRepository authRepository = new AuthRepository();
            authService = new AuthService(authRepository);
        }

        /// <summary>
        /// Remove the instance of the class
        /// </summary>
        public static void RemoveInstance()
        {
            customerService = null;
            accountService = null;
            authService = null;
        }
    }
}
