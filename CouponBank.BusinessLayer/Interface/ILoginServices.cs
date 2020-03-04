using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Interface
{
    public interface ILoginServices
    {
        bool Register(User user);
        bool Login(string UserName, string password);
        bool ResetPassword(string Password, string UserName);

    }
}
