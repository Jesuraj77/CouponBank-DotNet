using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponBank.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CouponBank.Web.Controllers
{
    public class AdminController : Controller
    {
        public List<CommissionDetails> GetAllCommisionList()
        {
            //Write a code to get all  commission
            List<CommissionDetails> CommissionDetail = new List<CommissionDetails>();
            return CommissionDetail;
        }

        public List<BankTransaction> GetAllTransaction()
        {
            //Write a code to GetAllTransaction
            List<BankTransaction> BankTransaction = new List<BankTransaction>();
            return BankTransaction;
        }

        public List<User> GetAllUserList()
        {
            //Write a code to GetAllUserList
            List<User> UserList = new List<User>();
            return UserList;
        }

        public IActionResult GetCommisionById(int CommisionId)
        {
            //Write a code to GetCommisionById
            CommissionDetails CommissionDetails = new CommissionDetails();
            return View();
        }

        public bool InActiveUser(List<int> UserId)
        {
            //Write a code to InActiveUser
            return true;
        }
    }
}