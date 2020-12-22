using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_3
{
    public class SpecialItem: Goods
    {
        public SpecialItem(String title) : base(title) { }
        public override int GetBonus(int qty, double price)
        {
            return 0;
        }
        public override double GetDiscount(int qty, double price)
        {
            double discount = 0.0;
            if (qty > 10)
                return discount = ((qty * price) * 0.005);
            else
                return 0;
        }
    }
}
