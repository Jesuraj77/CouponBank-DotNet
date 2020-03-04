using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Entities
{
   public class User
   {
        public  virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime Created_at { get; set; }
        public virtual string role { get; set; }
        public virtual int CouponValue { get; set; }
        public virtual string CouponPhoto { get; set; }
    }
}
