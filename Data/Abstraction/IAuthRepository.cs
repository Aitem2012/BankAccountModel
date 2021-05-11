using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstraction
{
    public interface IAuthRepository
    {
        bool CreateUser(string emailAddress, byte[] passwordHash, byte[] passwordSalt, string customerId);
        bool UserExist(string email);
        User UserIsValid(string email);
    }
}
