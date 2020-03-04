using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Interface
{
    public interface  IUserServices
    {
        bool AddCoupon(BankCoupon bankcoupon);
        BankCoupon RequestCoupon(int UserId);
        

    }
}
