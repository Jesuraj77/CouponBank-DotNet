using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponBank.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CouponBank.Web.Controllers
{
    public class UserController : Controller
    {
        public bool AddCoupon(BankCoupon bankcoupon)
        {
            //write a code to addcoupon
            return true;
        }

        

        public BankCoupon RequestCoupon(int UserId)
        {
            //write a code to RequestCoupon
            BankCoupon BankCoupon = new BankCoupon();
            return BankCoupon;
        }

        
    }
}