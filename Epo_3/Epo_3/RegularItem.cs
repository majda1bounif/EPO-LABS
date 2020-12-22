using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_3
{
    public class RegularItem : Goods
    {
        public RegularItem(String title) : base(title) { }
        public override int GetBonus(int qty, double price)
        {
            int bonus = 0;
            return bonus = (int)(qty * price * 0.05);
        }
        public override double GetDiscount(int qty, double price)
        {
            double discount = 0.0;
            if (qty > 2)
                return discount = ((qty * price) * 0.03);
            else
            {
                return 0;
            }

        }
    }
  
}
