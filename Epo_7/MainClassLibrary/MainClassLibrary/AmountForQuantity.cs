using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class AmountForQuantity : IBonusStrategy
    {
        private int _Bonusquantity;
        private double _percent;
        public AmountForQuantity(int Bonusquantity, double percent)
        {
            _Bonusquantity = Bonusquantity;
            _percent = percent;
        }
        public int GetBonus(int quantity, double price)
        {
            return (int)(price * quantity* _percent);
        }
        public bool PossibilityOfBonus(int quantity, double price)
        {
            if (_Bonusquantity != -1 & quantity > _Bonusquantity) return true;
            return false;
        }
    }
    //public class  AmountForQuantity : IBonusStrategy
    //{
    //    public  int GetBonus(int quantity, double price)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}


