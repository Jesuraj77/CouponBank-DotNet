using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Entities
{
   public class CommissionDetails
    {
        public virtual int CommisionId { get; set; }
        public virtual int TransactionId { get; set; }
        public virtual int CommissionFare { get; set; }
        public virtual DateTime datetime { get; set; }
        public virtual int UserId { get; set; }
    }
}
