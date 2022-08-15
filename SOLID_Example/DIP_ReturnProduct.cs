using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class DIP_ReturnProduct
    {
        IDIP_RefundMoney refundMoney;
        public string RefundMoney()
        {
            var r1 = refundMoney.RefundMoney();
            return r1.ToString();
        }
    }
}
