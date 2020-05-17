using System;
using System.Collections.Generic;
using System.Text;

namespace IMEPaySDK
{
    public interface MakePaymentImepay
    {
        void getDataImePay(string amt, string productName, string uniqueId);
    }
}
