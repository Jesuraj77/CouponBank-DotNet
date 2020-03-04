using CouponBank.BusinessLayer.Interface;
using CouponBank.DataLayer.NHibernateConfigurations;
using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {

        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddCoupon(BankCoupon bankcoupon)
        {
            return true;
        }

        public BankCoupon RequestCoupon(int UserId)
        {
            BankCoupon BankCoupon = new BankCoupon();
            return BankCoupon;
        }
        public BankCoupon GetBankCouponById(int BankCoponId)
        {
            BankCoupon BankCoupon = new BankCoupon();
            return BankCoupon;
        }



    }
}
