using CouponBank.BusinessLayer.Interface;
using CouponBank.DataLayer.NHibernateConfigurations;
using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {

        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }

        public List<CommissionDetails> GetAllCommisionList()
        {
            List<CommissionDetails> CommissionDetail = new List<CommissionDetails>();
            return CommissionDetail;
        }

        public List<BankTransaction> GetAllTransaction()
        {
            List<BankTransaction> BankTransaction = new List<BankTransaction>();
            return BankTransaction;
        }

        public List<User> GetAllUserList()
        {
            List<User> UserList = new List<User>();
            return UserList;
        }

        public CommissionDetails GetCommisionById(int CommisionId)
        {
            CommissionDetails CommissionDetails = new CommissionDetails();
            return CommissionDetails;
        }

        public bool InActiveUser(List<int> UserId)
        {
            return true;
        }
    }
}
