using CouponBank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.BusinessLayer.Interface
{
   public interface IAdminServices
   {
        List<User> GetAllUserList();
        bool InActiveUser(List<int> UserId);
        List<BankTransaction> GetAllTransaction();
        List<CommissionDetails> GetAllCommisionList();
        CommissionDetails GetCommisionById(int CommisionId);

    }
}
