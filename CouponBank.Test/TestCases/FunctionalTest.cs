using CouponBank.BusinessLayer.Services;
using CouponBank.DataLayer.NHibernateConfigurations;
using CouponBank.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CouponBank.Test.TestCases
{
    public class FunctionalTest
    {
        private readonly UserServices _UserService;
        private readonly AdminServices _AdminService;
        private readonly LoginServices _LoginService;
        private readonly BankServices _BankServices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public FunctionalTest()
        {
            _UserService = new UserServices(_session);
            _AdminService = new AdminServices(_session);
            _LoginService = new LoginServices(_session);
            _BankServices = new BankServices(_session);
        }

        User user = new User()
        {
            Id = 1,
            UserName = "John",
            Email = "John@gamail.com",
            Password = "John123",
            Status = "aa",
            Created_at=DateTime.Now,
            role="User"

        };

        [Fact]
        public void TestFor_Valid_Registration()
        {
            //Arrange
            //Action
            var IsRegistered = _LoginService.Register(user);

            //Assert
            Assert.True(IsRegistered);
        }


        [Fact]
        public void TestFor_Valid_Login()
        {
            //Arrange
            //Action
            var IsLogged = _LoginService.Login(user.UserName, user.Password);

            //Assert
            Assert.True(IsLogged);
        }


        [Fact]
        public void TestFor_Valid_ResetPassword()
        {
            //Arrange
            //Action
            var IsChanged = _LoginService.ResetPassword(user.UserName, user.Password);

            //Assert
            Assert.True(IsChanged);
        }

        //User

        [Fact]
        public void TestFor_Valid_AddCoupon()
        {


            //Arrange
            BankCoupon bankCoupon = new BankCoupon()
            {
                CouponId = 1,
                UserID = 1,
                CouponImage = "ss",
                CouponNumber = "1",
                Couponvalue = 1,
                Created_at = DateTime.Now
            };
            
            //Action
            var IsAdded = _UserService.AddCoupon(bankCoupon);

            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void TestFor_Valid_RequestCoupon()
        {
            BankCoupon bankcoupon = new BankCoupon()
            {
                CouponId = 1
            };
            //Arrange
            //Action
            var bankCoupon = _UserService.RequestCoupon(user.Id);
           
            var getbBankCoupon = _UserService.GetBankCouponById(bankcoupon.CouponId);
            //Assert
            Assert.Equal(getbBankCoupon, bankCoupon);
        }

        [Fact]
        public void TestFor_Valid_MakeTransaction()
        {
            //Arrange
            BankTransaction bankTransaction = new BankTransaction() 
            {

                UserId=21,
                CouponId=1,
                ReceivedFrom=1,
                PaidTo=1,
                Datetime=DateTime.Now,
                Status="Active",
                CouponValue=200,
                CreditAmount=1000,
                DebitAmount=12,
                AccountBalance=100

            };
            //Action
            var IsSucceedTransaction = _BankServices.MakeTransaction(bankTransaction);

            //Assert
            Assert.True(IsSucceedTransaction);
        }



        //Admin

        [Fact]
        public void TestFor_GetAllUser()
        {
            //Arrange
            //Action
            var listOfUser = _AdminService.GetAllUserList();

            //Assert
            Assert.NotNull(listOfUser);
        }

        [Fact]
        public void TestFor_InActivateUsers()
        {
            //Arrange
            var listOfUserForInActivate = new List<int>()
            { 
                1, 2 
            };
            //Action
            var IsInActivated = _AdminService.InActiveUser(listOfUserForInActivate);

            //Assert
            Assert.True(IsInActivated);
        }

        [Fact]
        public void TestFor_GetAllTransactions()
        {
            //Arrange
            //Action
            var allTransactionList = _AdminService.GetAllTransaction();

            //Assert
            Assert.NotNull(allTransactionList);
        }


        [Fact]
        public void TestFor_GetAllCommissionList()
        {
            //Arrange
            //Action
            var allCommitionList = _AdminService.GetAllCommisionList();

            //Assert
            Assert.NotNull(allCommitionList);
        }


        [Fact]
        public void TestFor_GetCommissionById()
        {
            CommissionDetails CommissionDetails = new CommissionDetails()
            {
                CommisionId = 1,
            };
            //Arrange
            //Action
            var commitionById = _AdminService.GetCommisionById(CommissionDetails.CommisionId);

            //Assert
            Assert.NotNull(commitionById);
        }



    }
}
