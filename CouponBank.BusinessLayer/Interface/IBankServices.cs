using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Interface
{
    public interface IBankServices
    {
        bool MakeTransaction(BankTransaction banktransaction);
    }
}

