using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class FixedAmount: IBonusStrategy
    {
        double _percent;
        int _Bonusquantity;
        public FixedAmount(double percent, int Bonusquantity)
        {
            _percent = percent;
            _Bonusquantity = Bonusquantity;
        }
        public int GetBonus(int quantity, double price)
        {
            return (int)(price *_percent);
        }
        public bool PossibilityOfBonus(int quantity, double price)
        {
            if (_Bonusquantity != -1 & quantity > _Bonusquantity) return true;
            return false;
        }
    }
  
}


