using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class Goods
    {
      
        private String _title;
        private int _priceCode;
        IDiscountStrategy _discount;
        IBonusStrategy _bonuses;
        IUseBonus _useBonus;
        public string _type { get; private set; }
        public Goods(String title, IDiscountStrategy discount, IBonusStrategy bonuses, string type)
        {
            _title = title;
            _discount = discount;
            _bonuses = bonuses;
            //_useBonus = useBonus;
            _type = type;

        }
        public int getPriceCode()
        {
            return _priceCode;
        }
        public void setPriceCode(int arg)
        {
            _priceCode = arg;
        }
        public String getTitle()
        {
            return _title;
        }

        //public GetDiscount
        public double GetDiscount(int quantity, double price)
        {
            return _discount.GetDiscount(quantity, price);
        }


        //public GetBonus
        public int GetBonus(int quantity, double price)
        {
            return _bonuses.GetBonus(quantity, price);
        }

        //using bonuses
        public int GetUsedBonus(int quantity, double price, Customer customer)
        {
            return _useBonus.GetUsedBonus(quantity, price, customer);
        }
        //ability to use bonuses?
        public bool PossibilityOfBonus(int quantity, double price)
        {
            return _bonuses.PossibilityOfBonus(quantity, price);
        }
    }
}
