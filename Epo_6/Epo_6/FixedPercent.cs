using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_6
{
    public class FixedPercent: IDiscountStrategy
    {
        private double _percent;
        public FixedPercent(double percent)
        {
            _percent = percent;
        }
        public double GetDiscount(int quantity, double price)
        {
            double discount = GetSum()*_percent;
            return discount;
            double GetSum()
            {
                return quantity * price;
            }
        }
    }
}
