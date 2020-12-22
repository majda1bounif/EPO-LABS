using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_4
{
    public class SalesItem : Goods
    {
        public SalesItem(String title) : base(title)
        {
        }
        public override int GetBonus(int qty, double price)
        {
            int bonus = 0;
            return bonus = (int)(qty * price * 0.01);
        }
        public override double GetDiscount(int qty, double price)
        {
            double discount = 0.0;
            if (qty > 3)
                return discount = ((qty * price) * 0.01);
            else
                return 0;
        }
    }

}
