using Core.Interfaces;
using Data.Abstraction;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public bool CreateUser(string emailAddress, byte[] passwordHash, byte[] passwordSalt, string customerId)
        {
            return _authRepository.CreateUser(emailAddress, passwordHash, passwordSalt, customerId);
        }

        public bool UserExist(string email)
        {
            return _authRepository.UserExist(email);
        }

        public User UserIsValid(string email)
        {
            return _authRepository.UserIsValid(email);
        }
    }
}
