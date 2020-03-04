using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Entities
{
   public class BankCoupon
    {
        public virtual int CouponId { get; set; }
        public virtual int UserID { get; set; }
        public virtual string CouponImage { get; set; }
        public virtual string CouponNumber { get; set; }
        public virtual int Couponvalue { get; set; }
        public virtual DateTime Created_at { get; set; }
    }
}
