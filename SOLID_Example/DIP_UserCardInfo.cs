using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class DIP_UserCardInfo : IDIP_RefundMoney
    {
        public string CardNumber { get; set; }
        public string UserName { get; set; }
        public string CVCNumber { get; set; }
        public string IBANNumber { get; set; }

        public string RefundMoney()
        {
            return $"{UserName} {IBANNumber}";
        }

    }
}
