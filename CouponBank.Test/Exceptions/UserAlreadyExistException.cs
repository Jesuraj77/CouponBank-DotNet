using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Test.Exceptions
{
    public class UserAlreadyExistException:Exception
    {
        public string Messages = "User Already Exist";

        public UserAlreadyExistException(string message)
        {
            Messages = message;
        }

    }
}
