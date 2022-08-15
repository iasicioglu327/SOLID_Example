using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class OCP_MainProductSaleInfo
    {
        public string ProductName { get; set; }
        public int NumberOfSales { get; set; }

        public virtual int CalculatePrice()
        {
            return NumberOfSales * 500;
        }
    }
}
