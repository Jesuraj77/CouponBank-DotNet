using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Test.Exceptions
{
    public class UserAlreadyExistException
    {
        private string Messages = "User already registered..Please login";

        public UserAlreadyExistException(string messages)
        {
            Messages = messages;
        }

    }
}
