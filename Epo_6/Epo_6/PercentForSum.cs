using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_6
{
    public class PercentForSum : IDiscountStrategy
    {
        private double _sum, _percent;
        public PercentForSum(double sum, double percent)
        {
            _sum = sum;
            _percent = percent;
        }
        public double GetDiscount(int quantity, double price)
        {
            double discount = 0;
            if (price >= _sum)
                discount = GetSum() * _percent;

            return discount;
            double GetSum()
            {
                return quantity * price;
            }
        }
    }
}
