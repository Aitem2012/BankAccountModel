using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICustomerService
    {
        Customer RegisterCustomer(string firstName, string lastName);
        User GetCustomerByEmail(string email);
    }
}
