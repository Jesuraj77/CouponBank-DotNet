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
    public class BoundaryTest
    {
        private readonly UserServices _UserService;
        private readonly AdminServices _AdminService;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            _UserService = new UserServices(_session);
            _AdminService = new AdminServices(_session);
        }


        User user = new User()
        {
            CouponValue = 20,
            CouponPhoto = ""
        };


        [Fact]
        public void BoundaryTestFor_CouponValueGreaterThanTwenty()
        {
            //Action
            var minValueOfCoupon = 20;
            //Assert
            Assert.InRange(user.CouponValue, minValueOfCoupon, 2147483647);
        }

        [Fact]
        public void BoundaryTestFor_UserPassword_Length()
        {
            var MinLength = 4;
            var MaxLength = 20;

            //Action
            var buyeractualLength = user.Password.Length;

            //Assert
            Assert.InRange(buyeractualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTestFor_ValidPhotoFormat()
        {
            //Action
            var photoFaormat = user.CouponPhoto;

            //Assert
            Assert.Contains(".jpeg", photoFaormat);
        }
    }
}
