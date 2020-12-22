using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_3
{
    public class Goods
    {
  
        private String _title;
        private int _priceCode;
        public Goods(String title)
        {
            _title = title;

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
        public virtual double GetDiscount(int quantity, double price)
        {

            return 0;
        }


        //public GetBonus
        public virtual int GetBonus(int quantity, double price)
        {
        
            return 0;
        }

    }
}
