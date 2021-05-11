using Data.Abstraction;
using Data.Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BankWorldDbContext _ctx;

        public AuthRepository()
        {
            _ctx = new BankWorldDbContext();
        }

        /// <summary>
        /// Create a user email and password for login in
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool CreateUser(string emailAddress, byte[] passwordSalt, byte[] passwordHash, string customerId)
        {
            User user = new User
            {
                Email = emailAddress,
                PasswordHash = Convert.ToBase64String(passwordHash),
                PasswordSalt = Convert.ToBase64String(passwordSalt),
                CustomerId = customerId
            };
            //DataStore.users.Add(user);
            //DataAccess.RegisterCustomerAuthentication(user);
            _ctx.Users.Add(user);
            var res = _ctx.SaveChanges();

            if (res >= 1) return true;
            

            return false;
        }
        public bool UserExist(string email)
        {
            var res = _ctx.Users.Select(x => x).FirstOrDefault(x => x.Email == email);

            if (res != null)
            {
                return true;
            }
            return false;
        }



        public User UserIsValid(string email)
        {
            if (UserExist(email))
            {
                return _ctx.Users.FirstOrDefault(x => x.Email == email);
                //return DataAccess.RetrieveCustomerID(email);
            }
            return null;
        }
    }
}
