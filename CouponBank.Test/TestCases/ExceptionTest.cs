using CouponBank.BusinessLayer.Services;
using CouponBank.DataLayer.NHibernateConfigurations;
using CouponBank.Entities;
using CouponBank.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CouponBank.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly UserServices _UserService;
        private readonly AdminServices _AdminService;
        private readonly BankServices _BankService;
        private readonly LoginServices _LoginService;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public ExceptionTest()
        {
            _UserService = new UserServices(_session);
            _AdminService = new AdminServices(_session);
            _BankService = new BankServices(_session);
            _LoginService = new LoginServices(_session);
        }

        

        [Fact]
        public void ExceptionTestFor_UserLogin()
        {
            //Arrange
            User user = new User();
            //Action
            var ex = Assert.Throws<UserNotFoundException>(() => _LoginService.Login(user.Email, user.Password));
            //Assert
            Assert.Equal("User Not Found", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserRegistration()
        {
            //Arrange
            User user = new User()
            {
                Id = 1,
                UserName = "John",
                Email = "John@gamail.com",
                Password = "John123",
                Status = "aa",
                Created_at = DateTime.Now,
                role = "User"

            };

            //Action
            var ex = Assert.Throws<UserAlreadyExistException>(() => _LoginService.Register(user));
            //Assert
            Assert.Equal("User already registered.. Please login", ex.Messages);
        }

        [Fact]
        public void ExceptionforMakeTransaction()
        {
            BankTransaction banktransaction = new BankTransaction()
            {
                TransactionId = 1,
                UserId = 1,
                CouponId = 1,
                ReceivedFrom = 1,
                PaidTo = 1,
                Datetime = DateTime.Now,
                CouponValue = 1,

            };

            var ex = Assert.Throws<ExceptionforMakeTransaction>(() => _BankService.MakeTransaction(banktransaction));
            //Assert
            Assert.Equal("Transaction Failled", ex.Messages);


        }

    }
}
