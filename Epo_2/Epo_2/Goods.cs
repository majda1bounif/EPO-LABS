using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_2
{
    public class Goods
    {
        public const int REGULAR = 0;
        public const int SALE = 1;
        public const int SPECIAL_OFFER = 2;
        private String _title;
        private int _priceCode;
        public Goods(String title, int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
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

            double discount = 0.0;
            switch (getPriceCode())
            {
                case Goods.REGULAR:
                    if (quantity > 2)
                        return discount = ((quantity*price)* 0.03);
                    break;
                case Goods.SPECIAL_OFFER:
                    if (quantity> 10)
                        return discount = ((quantity*price) * 0.005);
                    break;
                case Goods.SALE:
                    if (quantity> 3)
                        return discount = ((quantity*price) * 0.01);
                    break;
            }
            return discount;
        }


        //public GetBonus
        public int GetBonus(int quantity, double price)
        {
            int bonus = 0;
            switch (getPriceCode())
            {
                case Goods.REGULAR:
                    bonus = (int)(quantity * price * 0.05);
                    break;
                case Goods.SALE:
                    bonus = (int)(quantity * price* 0.01);
                    break;
            }
            return bonus;

        }

    }
}
