using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class OCP_ProductFirstVersionSaleInfo
    : OCP_MainProductSaleInfo
    {
        public override int CalculatePrice()
        {
            return NumberOfSales * 90;
        }
    }
}
