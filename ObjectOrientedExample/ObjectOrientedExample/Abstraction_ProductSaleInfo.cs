using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedExample
{
    internal abstract class Abstraction_ProductSaleInfo
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public int NumberOfSales { get; set; }

        public abstract int GetPrice();
        
       

    }
}
