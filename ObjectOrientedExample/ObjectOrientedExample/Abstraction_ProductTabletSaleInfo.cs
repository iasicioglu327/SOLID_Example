using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedExample
{
    internal class Abstraction_ProductTabletSaleInfo : Abstraction_ProductSaleInfo
    {
        public override int GetPrice()
        {
            return NumberOfSales * 15000;
        }
    }
}
