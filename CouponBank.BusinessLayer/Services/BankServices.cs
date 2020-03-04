using CouponBank.BusinessLayer.Interface;
using CouponBank.DataLayer.NHibernateConfigurations;
using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Services
{
    public class BankServices : IBankServices
    {
        private readonly IMapperSession _session;

        public BankServices(IMapperSession session)
        {
            _session = session;
        }

        public bool MakeTransaction(BankTransaction banktransaction)
        {
            return true;
        }
    }
}
