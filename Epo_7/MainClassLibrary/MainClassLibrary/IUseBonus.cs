using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public interface IUseBonus
    {
        int GetUsedBonus(int quantity, double price, Customer customer);
    }

}

