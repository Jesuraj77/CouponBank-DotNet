using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Test.Exceptions
{
   public class UserNotFoundException : Exception
    {
        public string Messages = "User is Not found";

        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
