using Data.Data;
using Data.Implementation;
using Data.Implementations;
using Model;
using Moq;
using System;
using Utilities;
using Xunit;

namespace Data.Test
{
    public class CustomerDataTest
    {
        [Fact]
        public void RetrieveCustomerIsTrue()
        {
            // Arrange

            var pass = Utilities.Utilities.GenerateHash("1234");

            var cus = new CustomerRepository();
            var userr = new AuthRepository();
            var use = cus.CreateCutomer("Solomon", "Young");
            userr.CreateUser("aitem@aitem.com", pass[0], pass[1], use.CustomerId);
            var user = userr.UserIsValid("aitem@aitem.com");
            var expected = cus.GetCustomerByEmail(user.Email);

            // Act

            // Assert
            Assert.Equal(expected.CustomerId, user.CustomerId);
            
            
        }

        [Fact]
        public void RetrieveCustomerIsInvalid()
        {
            // Arrange
            var cus = new CustomerRepository();
            var expected = cus.GetCustomerByEmail("aitem@ai.com");

            // Act

            // Assert
            Assert.Null(expected);


        }

        [Fact]
        public void UserExistIsValid()
        {
            // Arrange

            var pass = Utilities.Utilities.GenerateHash("1234");

            var cus = new CustomerRepository();
            var userr = new AuthRepository();
            var use = cus.CreateCutomer("Solomon", "Young");
            userr.CreateUser("aitem@aitem.com", pass[0], pass[1], use.CustomerId);
            var user = userr.UserExist("aitem@aitem.com");
           

            // Act

            // Assert
            Assert.True(user);
        }
        [Fact]
        public void UserExistNotValid()
        {
            // Arrange

            var pass = Utilities.Utilities.GenerateHash("1234");

            var cus = new CustomerRepository();
            var userr = new AuthRepository();
            
            var user = userr.UserExist("aitem@aitem.com");


            // Act

            // Assert
            Assert.False(user);
        }
    }
}
