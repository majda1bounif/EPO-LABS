using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class AmountForSum : IBonusStrategy
    {
        private double _sum, _percent, _Bonusquantity;
        public AmountForSum(double sum, double percent, int Bonusquantity)
        {
            _sum = sum;
            _percent = percent;
            _Bonusquantity = Bonusquantity;
        }
        public int GetBonus(int quantity, double price)
        {
            if (price*quantity > _sum) return (int)(price * quantity * _percent);
            return 0;

                /// OR
                /// 
                //if (price> _sum)
                //return (int)(price * _percent);

        }
        public bool PossibilityOfBonus(int quantity, double price)
        {
            if (_Bonusquantity != -1 & quantity > _Bonusquantity) return true;
            return false;
        }



















 
    }

}

