using System;
using System.Collections.Generic;
using System.Text;

namespace CouponBank.Test.Exceptions
{
    class ExceptionforMakeTransaction:Exception
    {
        public string Messages = "Transaction Failled";

        public ExceptionforMakeTransaction(string message)
        {
            Messages = message;
        }
    }
}
