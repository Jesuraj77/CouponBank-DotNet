using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponBank.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CouponBank.Web.Controllers
{
    public class LoginController : Controller
    {
        public bool Login(string UserName, string password)
        {
            //write a code to check for login
            return true;
        }

        public bool Register(User user)
        {
            //write a code to check for register if user exists
            return true;
        }

        public bool ResetPassword(string Password, string UserName)
        {
            //write a code to check for ResetPassword
            return true;

        }

    }
}