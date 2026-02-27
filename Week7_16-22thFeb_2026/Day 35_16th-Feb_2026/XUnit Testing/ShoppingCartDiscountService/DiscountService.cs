using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDiscountService
{
    public class DiscountService
    {
        public decimal ApplyDiscount(decimal total)
        {
            if (total >= 100) return total * 0.90m;
            if (total >= 50) return total * 0.95m;
            return total;
        }
    }

}
