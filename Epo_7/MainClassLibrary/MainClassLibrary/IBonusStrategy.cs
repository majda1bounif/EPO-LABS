using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public interface IBonusStrategy
    {
        int GetBonus(int quantity,double price);
        bool PossibilityOfBonus(int quantity, double price);

    }
}
