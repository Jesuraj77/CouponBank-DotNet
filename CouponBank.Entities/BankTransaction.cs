using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Entities
{
    public class BankTransaction
    {
        public virtual int TransactionId { get; set; }
        public virtual int UserId { get; set; }
        public virtual int CouponId { get; set; }
        public virtual int ReceivedFrom { get; set; }
        public virtual int PaidTo { get; set; }
        public virtual DateTime Datetime { get; set; }
        public virtual string Status { get; set; }
        public virtual int CouponValue { get; set; }
        public virtual int CreditAmount { get; set; }
        public virtual int DebitAmount { get; set; }
        public virtual int AccountBalance { get; set; }

    }
}
