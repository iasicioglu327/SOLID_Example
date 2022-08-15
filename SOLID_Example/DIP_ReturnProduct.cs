using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class DIP_ReturnProduct
    {
        IDIP_RefundMoney _refundMoney;
        public DIP_ReturnProduct(IDIP_RefundMoney refundMoney)
        {
            _refundMoney = refundMoney;
        }
        public string RefundMoney()
        {
            return _refundMoney.RefundMoney();
        }
    }
}
