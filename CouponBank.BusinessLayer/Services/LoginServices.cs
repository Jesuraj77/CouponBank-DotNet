using CouponBank.BusinessLayer.Interface;
using CouponBank.DataLayer.NHibernateConfigurations;
using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Services
{
    public class LoginServices:ILoginServices
    {
        private readonly IMapperSession _session;

        public LoginServices(IMapperSession session)
        {
            _session = session;
        }

        public bool Login(string UserName, string password)
        {
            return true;
        }

        public bool Register(User user)
        {
            return true;
        }

        public bool ResetPassword(string Password, string UserName)
        {
            return true;

        }

    }
}
