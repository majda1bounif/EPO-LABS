using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class PercentForQuantity : IDiscountStrategy
    {
        private int _quantity;
        private double _percent;
        public PercentForQuantity(int quantity, double percent)
        {
            _quantity = quantity;
            _percent = percent;
        }
        public double GetDiscount(int quantity, double price)
        {
            double discount = 0;
            if (quantity >= _quantity)
                discount = GetSum() * _percent;

            return discount;
            double GetSum()
            {
                return quantity * price;
            }
        }

    }
}
