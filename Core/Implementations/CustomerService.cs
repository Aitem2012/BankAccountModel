using Core.Interfaces;
using Data;
using Model;
using Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Implementations;

namespace Core.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;


        /// <summary>
        /// Customer service construction, taking customer repository as paramater
        /// </summary>
        /// <param name="customerRepository"></param>
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //Get a customer by Email
        public User GetCustomerByEmail(string email)
        {
            return _customerRepository.GetCustomerByEmail(email);
        }

        /// <summary>
        /// Register and return a customer type
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="passwordSalt"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public Customer RegisterCustomer(string firstName, string lastName)
        {
            return _customerRepository.CreateCutomer(firstName, lastName);
        }


    }
}
