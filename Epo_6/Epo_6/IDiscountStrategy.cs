using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_6
{
    public interface IDiscountStrategy
    {
        double GetDiscount(int quantity, double price);
    }
}
