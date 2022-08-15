using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class ISP_SellerAccount
    : IISP_SellProduct, IISP_CommentProduct
    {
        public void CommentProduct()
        {
            Console.WriteLine("Seller commented for product");
        }

        public void SellProduct()
        {
            Console.WriteLine("Seller sold the product");
        }
    }
}
