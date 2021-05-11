using Data.Abstraction;
using Data.Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly BankWorldDbContext _ctx;

        public CustomerRepository()
        {
            _ctx = new BankWorldDbContext();
        }
        //Create a customer
        public Customer CreateCutomer(string firstname, string lastname)
        {
            Customer customer = new Customer
            {
                FirstName = firstname,
                LastName = lastname,

            };
            //DataStore.customers.Add(customer);
            //var reg = DataAccess.RegisterCustomer(customer);
            _ctx.Customers.Add(customer);
            var res = _ctx.SaveChanges();
            if (res >= 1) return customer;
            
            return null;
        }

        //Get customer by email
        public User GetCustomerByEmail(string email)
        {
            var customer = _ctx.Users.Include("Customer").FirstOrDefault(x => x.Email == email);

            //return DataAccess.RetrieveCustomerByEmail(email);

            return customer;
        }
    }
}
