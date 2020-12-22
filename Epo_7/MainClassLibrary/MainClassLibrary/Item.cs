using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class Item
    {
        private Goods _Goods;
        private int _quantity;
        private double _price;
        private Customer _customer;
        public Item(Goods Goods, int quantity, double price)
        {
            _Goods = Goods;
            _quantity = quantity;
            _price = price;
        }
        public int getQuantity()
        {
            return _quantity;
        }
        public double getPrice()
        {
            return _price;
        }
        public Goods getGoods()
        {
            return _Goods;
        }
        public int GetBonus()
        {
            return _Goods.GetBonus(_quantity, _price);

        }
        public double GetDiscount()
        {
            return _Goods.GetDiscount(_quantity, _price);

        }
        public double GetSum()
        {
            return _quantity * _price;
        }
        public bool PossibilityOfBonus()
        {
            return _Goods.PossibilityOfBonus(_quantity, _price);
        }

    }
}
