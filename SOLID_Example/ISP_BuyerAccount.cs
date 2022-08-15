using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example
{
    internal class ISP_BuyerAccount
    : IISP_BuyProduct, IISP_CommentProduct
    {
        public void BuyProduct()
        {
            Console.WriteLine("Buyer bought the product");
        }

        public void CommentProduct()
        {
            Console.WriteLine("Buyer commented for product");
        }
    }
}
