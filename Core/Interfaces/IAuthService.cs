using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        bool CreateUser(string emailAddress, byte[] passwordHash, byte[] passwordSalt, string customerId);
        bool UserExist(string email);
        User UserIsValid(string email);
    }
}
